using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUMLApplication
{
    class Staff: Person
    {

        #region properties
        public string School { get; set; }
        public double Pay { get; set; }
        #endregion

        #region methods

        public Staff()
        {

        }

        public Staff(string name, string address, string school, double pay): base(name, address)
        {
            this.School = school;
            this.Pay = pay;

        }

        //override ToString method
        public override string ToString()
        {
            return base.ToString() + " " + this.School + " " + this.Pay;
        }
        #endregion

    }
}
