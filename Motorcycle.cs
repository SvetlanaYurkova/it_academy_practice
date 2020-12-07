using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Xml.Schema;

namespace practice_lecture10
{
    class Motorcycle
    {
        private int ID;
        private string model;
        private string manufacture;
        private int year;
        private int mileage;
        private Engine engine;

        public Motorcycle(int ID, string model, string manufacture, Engine engine)
        {
            this.ID = ID;
            this.model = model !="" ? model : "Default model";
            this.manufacture = manufacture != "" ? manufacture : "Default manufacture";
            this.year = DateTime.Now.Year;
            this.mileage = mileage < 100 ? mileage : 100;
            this.engine = engine;
        }

        private void clear()
        {
            this.model = "Default model";
            this.manufacture = "Default manufacture";
            this.mileage = 100;
        }

        internal class Engine
        {
            private int volume;
            private int power;

            public Engine(int volume, int power)
            {
                this.volume = (volume > 125 && volume < 3200) ? volume : 125;
                this.power = (power > 50 && power < 300) ? power : 100;
            }
            public string toString()
            {
                return "volume = " + volume + " power = " + power;
            }

        }

        public string toString()
        {
            return "ID = " + ID + " model = " + model + " manufacture = " + manufacture + " year = " + year +
                   " mileage = " + mileage + ", Engine: " + engine.ToString();
        }

    }
}
