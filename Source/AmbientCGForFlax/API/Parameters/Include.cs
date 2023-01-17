using System.Collections.Generic;

namespace AmbientCGForFlax.API.Parameters
{
    public struct Include
    {
        public bool statisticsData;
        public bool tagData;
        public bool displayData;
        public bool dimensionsData;
        public bool relationshipData;
        public bool neighbourData;
        public bool variationsData;
        public bool downloadData;
        public bool previewData;
        public bool mapData;
        public bool usdData;
        public bool imageData;

        public string Formated
        {
            get
            {
                List<string> includes = new List<string>(12);
                if(statisticsData)
                    includes.Add("statisticsData");

                if(tagData)
                    includes.Add("tagData");

                if(displayData)
                    includes.Add("displayData");

                if(dimensionsData)
                    includes.Add("dimensionsData");

                if(relationshipData)
                    includes.Add("relationshipData");

                if(neighbourData)
                    includes.Add("neighbourData");

                if(downloadData)
                    includes.Add("downloadData");

                if(previewData)
                    includes.Add("previewData");

                if(mapData)
                    includes.Add("mapData");

                if(usdData)
                    includes.Add("usdData");

                if(imageData)
                    includes.Add("imageData");

                string urlParameter = "include=";
                for(int includeIdx = 0; includeIdx < includes.Count; includeIdx++)
                {
                    bool isNotFirst = includeIdx != 0;
                    if(isNotFirst)
                        urlParameter += ",";
                    
                    string currInclude = includes[includeIdx];
                    urlParameter += currInclude;
                }

                return urlParameter;
            }
        }
    }
}