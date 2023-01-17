namespace AmbientCGForFlax.API.Parameters
{
    public struct Search
    {
        private string _key;

        public string Formated
        {
            get
            {
                return string.Format("q={0}", _key);
            }
        }

        public void SetSearchKeys(params string[] keys)
        {
            _key = "";
            for(int keyIdx = 0; keyIdx < keys.Length; keyIdx++)
            {
                bool isNotFirst = keyIdx != 0;
                if(isNotFirst)
                    _key += ",";
                
                string currKey = keys[keyIdx];
                _key += currKey;
            }
        }
    }
}