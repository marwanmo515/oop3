using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3
{
    internal class Car
    {
        #region att
        private int id; //4 bytes
        private string? model; //4 bytes 
        private double speed; //8 bytes
        #endregion


        #region prop 
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        #endregion

        #region methods 
        public override string ToString()
        {
            return $"Car ID: {id}, Model: {model}, Speed: {speed} km/h";
        }


        #endregion

        #region cons
        public Car(int id , string model , double speed)
        {
            this.id = id;
            this.model = model;
            this.speed = speed; 

        }
        #endregion

    }
}