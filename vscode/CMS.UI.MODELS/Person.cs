using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.UI.MODELS
{
    public class Person
    {
        public string fname;
        private string lname;
        private int id;
        //<----------property example------------>
        public string Lname {
            get{
                return lname;
            }
            set{
                lname=value;
            }
            }
        // <---------------Auto property---------------->
        public int ID{get;set;}
    }
}