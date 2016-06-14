using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment3
{
    public class GiantPlanet : Planet
    {
    
        /// <summary>
        /// Private Instance Variable
        /// </summary>
        private string _type;

        public bool HasMoons()
        {
            throw new System.NotImplementedException();
        }
        public bool HasRings()
        {
            throw new System.NotImplementedException();

        }
        /// <summary>
        /// GiantPlanet Constructor Class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type)
        {

        }
    }
}