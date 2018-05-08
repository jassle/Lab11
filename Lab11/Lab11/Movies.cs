using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movies
    {
        #endregion
        #region Properties
        public string MovieName { get => MovieName; set => MovieName = value; }
        public string Category { get => Category; set => Category = value; }
        #endregion
        #region Constructors
        public Movies(string m, string c)
        {
            MovieName = m;
            Category = c;
        }
        #endregion

    }
}
