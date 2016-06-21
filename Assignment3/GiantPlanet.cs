using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * @Author: Hassan Kobeissi
 * @StudentNumber: 300847239
 * @Date Created: June, 06,2016
 * @Datee Released: June/17/2016
 * @Description: GiantPlanet sub class of Planet class. Implements IHasmoons and IHasRings interfaces
 * Version #: 0.0.3
 */
namespace Assignment3
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
    
        /// <summary>
        /// Private Instance Variable  - Gas or Ice
        /// </summary>
        private string _type;

        #region Public Properties
        //Public Properties
        public string Type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }
        /// <summary>
        /// Implementation of the HasMoons() method to return true Depending on it's Moons
        /// </summary>
        public bool HasMoons()
        {
            if(MoonCount > 0)
             {
                 return true;
             }
            return false;
        }
        /// <summary>
        /// Implementation of the HasRings() method to return true Depending on it's Rings
        /// </summary>
        public bool HasRings()
        {
            if(RingCount > 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region Constructor
        /// <summary>
        /// This is the GiantPlanet Class Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type):base(name,diameter,mass)
        {
            this.Type = type;

        }
        #endregion

        #region ToString()
        /// <summary>
        /// ToString() Override the inherited ToString() method so that it outputs Type.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString()  + String.Format("\n{0} is of Type: {1}",this.Name,Type);
        }
        #endregion
    }
}