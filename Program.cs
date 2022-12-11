//acc 4 nums from user and display its product
Console.WriteLine("Enter first number");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Enter second number");
int b=int.Parse(Console.ReadLine());
int c = a * b;
Console.WriteLine("Product of 2 no. is "+ c);

//display fibonacchi series
Console.WriteLine("Fibonacci Series od 10 digits");
int count = 1;
Console.WriteLine("0,1,")
for(int i = 0; i < count; i++)
{

}


//accept num from user and check wheter its perfect number or not
namespace _9Dec_Q1
{
    class CodeFile1
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter the number of terms required in fibonacci series");
            int a = int.Parse(Console.ReadLine());

            int t1 = 0, t2 = 1, t3;

            Console.WriteLine("Fibonacci Series:");
            if (a == 1)
            {

                Console.Write(t1);
            }
            else
            {
                Console.Write(t1 + " " + t2 + " ");

                for (int i = 2; i < a; i++)
                {

                    t3 = t1 + t2;
                    Console.Write(t3 + " ");
                    t1 = t2;
                    t2 = t3;

                }
            }
        }
    }
}


//create an application that accept student id,student name, course and percentage from student.
//using method get datra.
//create another method display to display the same . use class and object
using System;
namespace Stud
{
    class getData
    {
        public int studid;
        public string name;
        public string course;
        public int perc;
        public void takeinfo()
        {
            Console.WriteLine("Enter id");
            studid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            name=(Console.ReadLine());
            Console.WriteLine("Enter Course");
            course=(Console.ReadLine());
            Console.WriteLine("Enter prec");
            perc=int.Parse(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Student ID "+studid);
            Console.WriteLine("Student Name " + name);
            Console.WriteLine("Student Course " + course);
            Console.WriteLine("Student Perc " + perc);
        }
        public static void Main()
        {
            getData obj=new getData();
            obj.takeinfo();
            obj.display();
        }
    }
}


// create application to accept character from user and check if vowel or not
using System;
namespace alphachecker
{
    class alphachecker
    {
        public string a;
        public void getData()
        {
            Console.WriteLine("ENter character");
            a = Console.ReadLine();
            a = a.ToUpper();
        }
        public void checker()
        {
            if (a == "A" || a == "E" || a == "I" || a == "O" || a == "U") Console.WriteLine("It is a vowel");
            else Console.WriteLine("It is a Consonant");
        }
        public static void Main(string[] args)
        {
            alphachecker obj = new alphachecker();
            obj.getData();
            obj.checker();
        }
    }
}


//create simple application to perform -> find factorial , money conversion, temperature conversion, distance formulae. (1 program itself)
using System;
namespace multiprog
{
    class multiprog
    {
        public static void fact(int i) {
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
        }
        public static void moneyconv(int i)
        {
            int dollar = 101;
            int ans = i * dollar;
            Console.WriteLine(i+"is converted into dollar"+ans);
        }
        public static void tempconv(int i)
        {
            int conv = 0;
            conv = i * (9 / 5) + 32;
            Console.WriteLine("Converted temp is" + conv);
        }
        public static void dist()
        {
            Console.WriteLine("Enter Co-ordinates of point 1 (x1,y1)");
            Console.Write("x1= ");
            float x1 = float.Parse(Console.ReadLine());
            Console.Write("y1= ");
            float y1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Co-ordinates of point 2 (x2,y2)");
            Console.Write("x2= ");
            float x2 = float.Parse(Console.ReadLine());
            Console.Write("y2= ");
            float y2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Distance = " + Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2))));
        }

        public static void Main(string[] args) {
            Console.WriteLine("Enter 1 for Factorial");
            Console.WriteLine("Enter 2 for money conversion");
            Console.WriteLine("Enter 3 for temperature conversion");
            Console.WriteLine("Enter 4 for distance formulae");
            int ch = Console.ReadLine("Enter choice");
        multiprog multiprog = new multiprog();
        multiprog.fact(1);
        multiprog.moneyconv(5);
        multiprog.tempconv(5);
        multiprog.dist();
        }
    }
}