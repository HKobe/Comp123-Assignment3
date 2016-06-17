using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/**
 * @Author: Hassan Kobeissi
 * @StudentNumber: 300847239
 * @Date Created: June, 06,2016
 * @Datee Released: June/17/2016
 * @Document Description: Returns a bool data type
 * Version #: 0.0.3
 */
namespace Assignment3
{
    public interface IHabitable
    {
        ///<summary>abstract method - force children to implement this method</summary>
        bool Habitable();
    }
}