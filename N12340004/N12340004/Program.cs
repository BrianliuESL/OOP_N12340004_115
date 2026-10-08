using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N12340004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student= new Student();
            student.id="N12340004";
            student.name="Brian";
            Console.WriteLine("ID:"+student.id+"Name:"+student.name);


            Student student1 = new Student();
            student1.id = "N12345678";
            student1.name = "Alan";
            Console.WriteLine("ID:" + student1.id + "Name:" + student1.name);


            Console.ReadLine();







        }



    }


    public class Student
    {
        public string id;
        public string name;

        public Student() 
        {
        
        
        
        
        
        
        }












    }
    

    







}
