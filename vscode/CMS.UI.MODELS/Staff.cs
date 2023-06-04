// USE OF 3 DIFFERENT TYPES OF FIELDS
// STATIC FIELD
using System;
namespace CMS.UI.MODELS{
    //<-----------Single Inheritance---------->
    public  class Staff : Person{
        //------------normal, read Only, Constant Field -----------------
        // normal field value can be changed anytime.
        // Read only value Cann't be changed (Except Constructor) 
        // Const never Be changed (By Classname it can be access only)
        public string Address="";
        public readonly int MaxStaff = 120;
        public const int SittingCapacity=200;
        // ---------Static Field is availble to all the instanes of the class--------------
        // (By Classname it can be access only)
        // It can Be changed anytime through it's access by it's (Classname.StsticField)
        public static int Area=1000;
        public Staff(){
            MaxStaff=140;
        }
    }
}