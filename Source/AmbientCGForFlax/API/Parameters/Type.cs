using System.Collections.Generic;

namespace AmbientCGForFlax.API.Parameters
{
    public struct Type
    {
        public bool _3dModel;
        public bool atlas;
        public bool brush;
        public bool decal;
        public bool hdri;
        public bool material;
        public bool plainTexture;
        public bool substance;
        public bool terrain;

        public string Formated
        {
            get
            {
                List<string> types = new List<string>(9);

                if(_3dModel)
                    types.Add("3DModel");

                if(atlas)
                    types.Add("Atlas");
                    
                if(brush)
                    types.Add("Brush");

                if(decal)
                    types.Add("Decal");

                if(hdri)
                    types.Add("HDRI");

                if(material)
                    types.Add("Material");

                if(plainTexture)
                    types.Add("PlainTexture");

                if(substance)
                    types.Add("Substance");

                if(terrain)
                    types.Add("Terrain");

                string formated = "type=";
                if(types.Count == 9)
                    return formated;

                for(int typeIdx = 0; typeIdx < types.Count; typeIdx++)
                {
                    bool isNotFirst = typeIdx != 0;
                    if(isNotFirst)
                        formated += ",";
                    
                    string currType = types[typeIdx];
                    formated += currType;
                }

                return formated;
            }
        }
    }
}