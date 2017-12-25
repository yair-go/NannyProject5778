using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class Nanny
    {
        public string ID { get; }

        public int Age { get; }

        #region Ctor
        public Nanny()
        {
            ID = "";
        }

        public Nanny(string id,int age)
        {
            ID = id;
            Age = age;
        }

        #endregion

        #region Methods
        public override string ToString()
        {
            return ID + " " + Age;

        }

        #endregion
    }

}