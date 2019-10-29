using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUMLApplication
{
    class Student:Person
    {

        #region properties
        public string Program { get; set; }
        public int Year { get; set; }
        public double Fee { get; set; }
        #endregion

        #region methods

        public Student()
        {

        }

        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            this.Program = program;
            this.Year = year;
            this.Fee = fee;
        }

        public override string ToString()
        {
            return base.ToString() + " " +this.Program + " " + this.Year + " " + this.Fee + " ";
        }


        #endregion

    }
}
