using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * @Author: Hassan Kobeissi
 * @StudentNumber: 300847239
 * @Date Created: June, 06,2016
 * Version #: 0.0.1
 */
namespace Assignment3
{
    public abstract class Planet
    {
        #region Private Instance Variables
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;
        #endregion
        #region public Planet 
        /// <summary>
        /// Planet Constructor Method
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public Planet(string name, double diameter, double mass)
       {
            name = _name;
            diameter = _diameter;
            mass = _mass;
       }
        #endregion
        #region Public Properties

        public double Diameter
        {
            get
            {
                return _diameter;
            }

        }

        public double Mass
        {
            get
            {
                return _mass;
            }
        }

        public int MoonCount
        {
            get
            {
                return _moonCount;
            }
            set
            {
                _moonCount = value;
            }

        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double OrbitalPeriod
        {
            get
            {
                return _orbitalPeriod;
            }

            set
            {
                _orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return _ringCount;
            }

            set
            {
                _ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return _rotationPeriod;
            }

            set
            {
                _rotationPeriod = value;
            }
        }
        #endregion
        #region ToString()
        public override string ToString()
        {
            return String.Format("Name: {0}\nDiameter: {1}\nMass: {2}", this.Name, this.Diameter, this.Mass);

        }
        #endregion
    }
}