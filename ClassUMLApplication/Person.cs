using System;
using System.Collections.Generic;
using System.Text;

namespace ClassUMLApplication
{
    class Person
    {
        //initializes properties
        #region properties
        public string Name { get; set; }
        public string Address { get; set; }
        #endregion

        #region methods

        public Person()
        {

        }

        public Person(string nameOne, string addressOne)
        {

            this.Name = nameOne;
            this.Address = addressOne;

        }


        public override string ToString()
        {
           return(this.Name + " " + this.Address);

        }
        #endregion

    }
}
