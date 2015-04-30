using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CCAIDemo.Entity
{
    public class Contract
    {
        public Contract()
        {
        }

        public int ID
        {
            get;
            set;
        }


        public string Name
        {
            get;
            set;
        }

        public List<FProperty> FPropertyForgeinList
        {
            get;
            set;
        }
    }
}
