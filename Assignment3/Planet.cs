﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * @Author: Hassan Kobeissi
 * @StudentNumber: 300847239
 * @DateCreated: June, 06,2016
 * @DateRelease: June, 17,2016
 * @Description: The Parent Class, Abstract Class Planet. Root of Assignment3.
 * Version #: 0.0.3
 */
namespace Assignment3
{
    public abstract class Planet
    {
        #region Private Instance Variables
        /*PRIVATE INSTANCE VARIABLES*/
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
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
       }
        #endregion

        #region Public Properties
        /*PUBLIC PROPERTIES*/
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
        /// <summary>
        /// Override the inherited ToString() method so	that it outputs	Name, Diameter and Mass to the Console.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Name of Planet: {0}\nDiameter of {1}: {2}\nMass of {3}: {4}", this.Name, this.Name, this.Diameter, this.Name,this.Mass);

        }
        #endregion
    }
}