using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

namespace Project1
{
    //derived class 'Submenu1' for Experience
    //inherit from abstract class AMenu
    class Submenu1 : AMenu
    {
        //abstract method 'mainoption()'
        public override void mainoption()
        {


            int companyname = int.Parse(Console.ReadLine());



            switch (companyname)
            {
                case 1:

                    Console.Clear();
                    subexperience();
                    break;

                case 2:
                    // Console.WriteLine("GoBack to Main");
                    goback();
                    break;







            }


        }


        public static void subexperience()
        {
            Console.Write("--------------SUBMENU----------------------\n");
            Console.WriteLine("(1) - Overview of job description");
            Console.WriteLine("(2) - Go Back to Main Menu");
            Console.Write("\nChoose from options above.");
            int option = int.Parse(Console.ReadLine());


            switch (option)
            {

                case 1:
                    Console.WriteLine("An industial training is provided to all interns for about 3 months with three weeks of training.\nInternship programs are a great way to gain real-world knowledge and experience,\nallowing interns to establish relationships with talented individuals, develop their skills, and get a boost to their productivity. ");
                    Console.WriteLine("\n\nPress enter to go back to Main menu");
                    Console.ReadKey();
                    goback();
                    
                    break;

                case 2:
                    Submenu1 menu2 = new Submenu1();
                    goback();
                    break;


            }

        }
            public static void goback()
            {
                bool finished = true;
                MainMenu menu1 = new MainMenu();
                menu1.mainoption();
                return;


            }
        }
    }



   

