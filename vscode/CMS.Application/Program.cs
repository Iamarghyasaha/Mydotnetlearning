using System;
using CMS.UI.DISPLAY;
using CMS.UI.MODELS;

namespace CMS.Application
{
    public class Program
    {
        static void Main(string[] args)
        {   
            int num ='c';
            Console.WriteLine(num);
            float a = Convert.ToInt32(33.5F);
            Console.WriteLine(a);
            Console.WriteLine(Convert.ToString(33.333
            ));
            Console.WriteLine(Double.Round(Math.Sqrt(33.5),2));
            Console.WriteLine(Math.Round(5555.66666F,2));
            Console.WriteLine(55.7777.ToString("0.00"));
            Console.WriteLine("Enter The Age in integer");
            int age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"AGE is {age}");
            Student s1= new Student();
            s1.Lname="saha";
            s1.fname="Arghya";
            Console.WriteLine(s1.Lname);
            s1.ID=101;
            Console.WriteLine(s1.ID);
            Staff st1= new Staff();
            st1.fname="AVIRUP";// public 
            st1.Lname="BISWAS";// private and use of Property
            st1.ID=102;// private and use of Auto Property
            Console.WriteLine($"{st1.fname} {st1.Lname}'s and ID id {st1.ID}");
            st1.Address="NEW DELHI 7485623 ";
            // Called Readonly field and showed the output
            Console.WriteLine(st1.MaxStaff);
            // Called Const Field And Showed Output. (By Classname it can be access only)
            Console.WriteLine(Staff.SittingCapacity);
            Staff.Area=500;
            Console.WriteLine(Staff.Area);
            Console.WriteLine(s1.GetFullName());
            Student s2=new Student("Avinash","Ghosh", 45);
            Console.WriteLine($"{s2.fname} {s2.Lname} {s2.ID}");
            s2.Height=170;
            Console.WriteLine(s2.Height);
            //s2.Phonenumber=""; because it's readonly prperty it can't be set
            Console.WriteLine(s2.Phonenumber);

        }
    }
}