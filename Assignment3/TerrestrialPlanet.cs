using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * @Author: Hassan Kobeissi
 * @StudentNumber: 300847239
 * @Date Created: June, 06,2016
 * @DateReleased: June, 17,2016
 * @DocumentDescription: Subclass of Planet Abstract class. Also Implements interfaces.
 * Version #: 0.0.3
 */
namespace Assignment3
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        #region Private Instance Variable _oxygen
        /// <summary>
        /// Private Instance Variable _oxygen
        /// </summary>
        private bool _oxygen;
        #endregion

        #region Constructor
        /// <summary>
        /// TerrestrialPlanet Constructor Method
        /// </summary>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name,diameter,mass)
        {
            this.Oxygen = oxygen;

        }
        #endregion

        #region Public Methods
        /// <summary>
        /// A public property Oxygen
        /// </summary>
        public bool Oxygen
        {
            get
            {
                return _oxygen;
            }

            set
            {
                _oxygen = value;
            }
        }
        /// <summary>
        /// Implementation of the Habitable() method to return true Depending if it's Habitable
        public bool Habitable()
        {
            if (Oxygen == true)
            {
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Implementation of the HasMoons() method to return true Depending on it's Moons
        /// </summary>
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            return false;
        }
        #endregion


        #region ToString()
        /// <summary>
        /// ToString() Override the inherited ToString() method so that it outputs Oxygen.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString() + String.Format("\nHas Oxygen? {0}", Oxygen);
        }
        #endregion
    }
}