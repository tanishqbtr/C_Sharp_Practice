using System;

namespace C_Sharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string uname = "Tanishq";
            int age = 23;
            char grade = 'A';
            double d1= 3.0;
            bool isMale = true;


            for (int i = 0; i < 5; i++)
                Console.WriteLine("Hello!" + uname + "Your age is" + age);

            Console.WriteLine(uname[3]);
            Console.WriteLine(uname.Length);
            Console.WriteLine(uname.ToUpper());
            Console.WriteLine(uname.ToLower());
            Console.WriteLine(uname.Contains("ish"));
            Console.WriteLine(uname.IndexOf("i")); //Only lists the first one, -1 if not present
            Console.WriteLine(uname.Substring(2,3)); //Initial Inedex, length of next characters
            Console.WriteLine(Math.Sqrt(36));

            Console.Write("Please Enter you name : ");
            string uname2 = Console.ReadLine();
            Console.WriteLine(uname2);
            string age2 = "24";
            int age3 = Convert.ToInt32(age2);
            Console.WriteLine("Your age + 10 = "+(age3+10));


            Console.ReadLine();
        }
    }
}
