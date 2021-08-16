using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project
{
    class Program
    {
        struct info {
            public string name;
            public string surname;
            public int rank;
            public double average;
            public int index;
            public string adress;
}
        static void Main(string[] args)
        {

            info[] stud1 = new info[100];
            StreamWriter sw = new StreamWriter("E:\\text4.txt");
            StreamReader sr = new StreamReader("E:\\text3.txt");
            sw.WriteLine("hello");


            int decision;

        start:
            Console.Clear();
            Console.WriteLine("        WELCOME TO OUR STUDENTS DATABASE ;");
            Console.WriteLine( );
            Console.WriteLine("  PRESS 1 to enter students to our database or to a text file ");
            Console.WriteLine();
            Console.WriteLine("  PRESS 2 to search for a student in our database ");
            Console.WriteLine();
            Console.WriteLine("  PRESS 3 to see students in our database ");
            Console.WriteLine();
            Console.WriteLine("  PRESS 4 to add information from a textfile");
            Console.WriteLine();
            Console.WriteLine("  PRESS 5 to Read about this application");
            Console.WriteLine();
            Console.WriteLine("  PRESS 6 for options ");
            Console.WriteLine();
            Console.WriteLine("  PRESS ENTER to exit ");

            decision = int.Parse(Console.ReadLine());
            Console.Clear();
       

            Console.Clear();
            switch (decision)
   {

                case 1:
                    goto menu1;
                    break;
                case 2:
                    goto menu2;
                    break;
                case 3:
                    goto menu3;
                    break;
                case 4:
                    goto menu4;
                    break;
                case 5:
                    goto menu5;
                    break;
                case 6:
                    goto menu6;
                    break;
                default:
                    Console.WriteLine("INVALID INPUT ");
                    Console.ReadLine();
                    goto start;
                    break;
  }
            
        menu1:
            Console.WriteLine("how many students do you want to add ");
            int size1 = int.Parse(Console.ReadLine());
            Console.Clear();
            
            for (int i = 1; i <= size1; i++)
            {

                Console.WriteLine("please enter z name of {0} student u want to add ", i);
                stud1[i].name = Console.ReadLine();
                Console.WriteLine("please enter z surname of {0} student you want to add", i);
                stud1[i].surname = Console.ReadLine();
                Console.WriteLine("please enter z rank of {0} student you want to add", i);
                stud1[i].rank = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter z average of {0} student you want to add", i);
                stud1[i].average = double.Parse(Console.ReadLine());
                Console.WriteLine("please enter z adress of {0} student you want to add",i);
                stud1[i].adress = Console.ReadLine();
                Console.WriteLine("please enter z index of {0} student you want to add", i);
                stud1[i].index = int.Parse(Console.ReadLine());
                Console.Clear();
               
            }
            Console.WriteLine("THOSE STUDENT HAVE BEEN ADDED SUCESSFULLY !!");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("press 1 to store the data in to a text file or 2 to goto to our MENU");
            int tt = int.Parse(Console.ReadLine());
            if (tt == 1)
            {
                for (int i = 1; i <= size1; i++)
                {
                    try
                    {
                        sw.WriteLine("          student {0}", i);
                        sw.WriteLine(stud1[i].name);
                        sw.WriteLine(stud1[i].surname);
                        sw.WriteLine(stud1[i].rank);
                        sw.WriteLine(stud1[i].average);
                        sw.WriteLine(stud1[i].adress);
                        sw.WriteLine(stud1[i].index);
                       

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("it is not working");
                        Console.ReadLine();
                    }
                }
                sw.Close();
                Console.WriteLine("the data you added is stored to a text file(E://text2.txt) sucessfully !! ");
                Console.ReadLine();
                goto start;
            }

            else
            { goto start; }
           
           

        menu2:
            Console.WriteLine("enter the index of the student you want to search ;");
            int index = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                if (index == stud1[i].index)
                {
                    Console.WriteLine("student's name ; " + stud1[i].name);
                    Console.WriteLine();
                    Console.WriteLine("student's surname ; " + stud1[i].surname);
                    Console.WriteLine();
                    Console.WriteLine("student's rank ; " + stud1[i].rank);
                    Console.WriteLine();
                    Console.WriteLine("student's average ; " + stud1[i].average);
                    Console.WriteLine();
                    Console.WriteLine("student's adress ; " + stud1[i].adress);
                  

                }
 }
                Console.ReadLine();
                goto start;
            

        menu3:
            Console.WriteLine("THE STUDENTS IN OUR DATABASE ARE ;; ");
            Console.WriteLine();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("The {0}  student's name is {1}", i, stud1[i].name);
                Console.WriteLine();
                Console.WriteLine("The {0}  student's surname is {1}", i, stud1[i].surname);
                Console.WriteLine();
                Console.WriteLine("The {0}  student's rank is {1}", i, stud1[i].rank);
                Console.WriteLine();
                Console.WriteLine("The {0}  student's Average is {1}", i, stud1[i].average);
                Console.WriteLine();
                Console.WriteLine("The {0}  student's Adress is {1}",i,stud1[i].adress);
                Console.ReadLine();
            }
            Console.ReadLine();
            goto start;

        menu6:
            Console.WriteLine();
            Console.WriteLine("SORRY, THERE IS NOTHING IN HERE !!!");
            Console.ReadLine();
            goto start;
         
        menu5:
            Console.Write("This app is designed , developed and coded by ; ");
            Console.WriteLine("NEHMIYA HABTAMU SHIKUR ; ");
            Console.WriteLine();
            Console.WriteLine("AND THANK YOU FOR USING THIS APPLICATION ;");
            Console.WriteLine();
            Console.WriteLine("IF TOU ENCOUNTER ANY PROBLEMS WHILE USING THIS APPLICATION ");
            Console.WriteLine("CONTACT US THROUGH OUR EMAIL ; nehmyahabtamu1@gmail.com");
            Console.WriteLine();
            Console.WriteLine("              THANK YOU !!");

            Console.ReadLine();
            goto start;

        menu4:
            Console.WriteLine();
            Console.WriteLine("fetching information from E:\\text3.txt to our database");
            Console.WriteLine();
            for (int i = 0; i <100; i++) { Console.Write("*");  }
            for (int i = 1; i < 4; i++) {
                stud1[i].name = sr.ReadLine();
                stud1[i].surname = sr.ReadLine();
                stud1[i].rank = int.Parse(sr.ReadLine());
                stud1[i].average = double.Parse(sr.ReadLine());
                stud1[i].adress = sr.ReadLine();
                stud1[i].index = int.Parse(sr.ReadLine());


            }
            Console.WriteLine();
            Console.WriteLine("information added !!");
            Console.ReadLine();
            goto start;









        }
    }
}
