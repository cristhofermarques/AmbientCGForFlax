using System.Collections.Generic;

namespace AmbientCGForFlax.API.Parameters
{
    public struct Method
    {
        public bool pbrApproximated;
        public bool pbrPhotogrammetry;
        public bool pbrProcedural;
        public bool pbrMultiAngle;
        public bool plainPhoto;
        public bool _3dPhotogrammetry;
        public bool hdriStitched;
        public bool hdriStitchedEdited;
        public bool unknownOrOther;

        public string Formated
        {
            get
            {
                List<string> methods = new List<string>(9);

                if(pbrApproximated)
                    methods.Add("PBRApproximated");

                if(pbrPhotogrammetry)
                    methods.Add("PBRPhotogrammetry");
                    
                if(pbrProcedural)
                    methods.Add("PBRProcedural");

                if(pbrMultiAngle)
                    methods.Add("PBRMultiAngle");

                if(plainPhoto)
                    methods.Add("PlainPhoto");

                if(_3dPhotogrammetry)
                    methods.Add("3DPhotogrammetry");

                if(hdriStitched)
                    methods.Add("HDRIStitched");

                if(hdriStitchedEdited)
                    methods.Add("HDRIStitchedEdited");

                if(unknownOrOther)
                    methods.Add("UnknownOrOther");

                string formated = "method=";
                if(methods.Count == 9)
                    return formated;

                for(int methodIdx = 0; methodIdx < methods.Count; methodIdx++)
                {
                    bool isNotFirst = methodIdx != 0;
                    if(isNotFirst)
                        formated += ",";
                    
                    string currMethod = methods[methodIdx];
                    formated += currMethod;
                }

                return formated;
            }
        }
    }
}