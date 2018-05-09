using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movies
    {
        private string movieName;
        private string category;
        #region Properties
        public string MovieName
        {
            set { movieName = value; }
            get { return movieName; }
        }
        public string Category
        {
            set { category = value; }
            get { return category; }
        }
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
