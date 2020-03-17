using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Ludvig_Baummann_Olsson
{
    class Person
    {
        public Person(int inAge, string inFName, string inLName, double inHeight, double inWeight)
        {
            age = inAge;
            fName = inFName;
            lName = inLName;
            height = inHeight;
            weight = inWeight;
        }

        private int age;

        private string fName;

        private string lName;

        private double height;

        private double weight;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string FName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
