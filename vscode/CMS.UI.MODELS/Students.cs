// --------C# Methods----------
// 1. NORMAL METHOD--NORMAL USER DEFINED FUNCTIONS
// 2. CONSTRUCTOR-- CALLED TO CREATE AN OBJECT/INSTANCE OF A CLASS
// 3. DESTRUCTOR-- CALLED WHEN AN CLASS INSTANCE IS BEING COLLECTED BY GARBAGE COLLECTOR
// 4. PROPERTIES-- Property is a member that provides Felexible Mechanism to READ,WRITE,COMPUTE the value of Private Fields
//    a.Auto Property: A Method where get and set implecitely defined
//    b.Read Only Prperty: A property with only Getter is called Read Only Property,This restrict changing the value of the property 
using System;
namespace CMS.UI.MODELS{
    public  class Student{
        public string fname;
        private string lname;
        private int id;
        private int height;
        private string phonenumber;
        //<<<<<<-----------2.CONSTRUCTOR-------------.>>>
        public Student(){
            Console.WriteLine("Non Parameterized Constructor called Student()");
            fname="";
            lname="";
        }
        public Student(string newfname, string newlname, int newid){
            Console.WriteLine("Parameterized Constructor called Student()");
            fname=newfname;
            lname=newlname;
            id= newid;
        }
        //<<<-----------3. Destructor--------------
        ~Student(){
            //Cleanup Operation-----Under Destructor
        }



        //<--------------4.Property-------------->
        public string Lname {//"Lname" is differnt from "private lname" to access this Field we have to use "Lname"
            get{
                return lname;
            }
            set{
                lname=value;
            }
            }
        public int ID{get{return id;}set{id=value;}}
        //------Auto Property-----
        // -----single line Auto Property-----
        public int Height{get;set;}
        //-------- Read Only Auto Property--------
        public string Phonenumber{get;}
        

        //<<<<------1. NORMAL METHOD----------->>>>
        public string GetFullName(){
            return($"{fname} {lname}");
        }


    }
}