using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{


    // class Mainmenu 
    //Base class
    class MainMenu
    {

        // using accessors to get and set option by user
        public int option;
   
        
        public int getOption()
        {
            return this.option;
        }
        public void setOption(int option)
            {
                option = this.option;
            }


       
        public void mainoption()
        {
            Console.Clear();
            Console.Write("----------------MAIN MENU---------------------");
            Console.WriteLine("\n1-Experience\n2-Education\n3-Skills\n4-Technological Skills\n5-Contact Details");
            Console.Write("\nChoose from options above.");
            option = int.Parse(Console.ReadLine());

            Console.Clear();
            switch (option)
            {
                case 1:
                    Console.Write("\n-------------SUBMENU---------------\n");
                    Console.WriteLine("(1)-company name CERIDIAN MAURITIUS 2022\n(2)-Go Back to Main menu.");
                    Console.Write("\nChoose from options above: ");
                    Submenu1 menu1 = new Submenu1();
                    menu1.mainoption();
                    return;

                case 2:
                    Submenu2 menu2 = new Submenu2();
                    menu2.mainoption();
                    break;

                case 3:
                    Console.WriteLine("Skills:\n\n->Time Management\n->Programming and Web Development\n->Teamwork and Collaboration\n->Creativity and Problem Solving.");
                    break;

                case 4:
                    Console.WriteLine("\nTechnological Stack:\n->Java\n->HTML\n->CSS\n->JavaScript\n->PHP\n->XML\n->JSON\n->SOAP\n->REST\n->C#");
                    break;

                case 5:
                    Console.WriteLine("\n-----CONTACT DETAILS-----\n");
                    Console.WriteLine("Home Address: 288,Avenue Serin,Beau Vallon\n");
                    Console.WriteLine("Email Address: haniajambocus23@gmail.com\n");
                    Console.WriteLine("Mobile Number: 5s2345690");
                    break;
            }

        }
        
       
    }
   

}

        
       

       
            
          


            





        
  