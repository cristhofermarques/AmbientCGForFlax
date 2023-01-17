using System.Collections.Generic;

namespace AmbientCGForFlax.API.Parameters
{
    public struct Sort
    {
        private static readonly string[] SortParameters = {"Latest", "Popular", "Downloads", "Alphabet", "Random"};

        public SortBy sortBy;

        public string Formated => string.Format("sort={0}", SortParameters[(int)sortBy]);

        public enum SortBy
        {
            Lastest = 0,
            Popular = 1,
            Alphabet = 2,
            Downloads = 3,
            Random = 4
        }
    }
}