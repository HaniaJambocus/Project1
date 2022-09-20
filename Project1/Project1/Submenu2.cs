using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    //Submenu2 for Education
    //derived class [Submenu2]
    //inherit from abstract class AMenu
    class Submenu2 : AMenu
    {
        //abstract method 'mainoption()'
        public override void mainoption()
        {
            bool finished = true;
            int option2;
            Console.Write("---------------SUBMENU---------------");
            Console.Write("\n(1) -Applied Computing Level 1\n(2) -Applied Computing Level 2\n(3) -Additional Training Attended\n(4) -Go Back To Main Screen\n");
            Console.Write("\nSelect from options above to display details of each university level: ");
            option2 = int.Parse(Console.ReadLine());
            Console.Clear();
            do
            {
                switch (option2)
                {
                    case 1:
                        Console.WriteLine("\n-----MODULES OF LEVEL1:------\nDGT1032Y-Web Development and Design\nDGT1038Y-Programming and Data Structures\nDGT1034Y-Mathematics for Computing\nDGT1033Y-Business Computing\nDGT1031Y-Database Systems and Administration\nDGT1036Y-Communication Skills");
                        Console.WriteLine("\n------Projects:------\nWebsite based on HTML,CSS,JAVAScript\nCERC Level French Rosetta Stone");
                        goback();
                        break;

                    case 2:
                        Console.WriteLine("\n------MODULES OF LEVEL 2 :-------\nDGT2030Y-Networking Principles\nDGT2034Y-Internet Technologies and Web Services\nDGT2035Y-Software Modellingand Design\nDGT2036Y-Principles of Software Development\nDGT2030Y-Enterprise System\nDGT2029Y-Multimedia Authoring and Development ");
                        Console.WriteLine("\n------Projects:------\nXML,SOAP,REST,JSON implementation in Website\nHTML5 GAME\nBusiness Case Process Analysis on Microsoft Dynamics\nConstruct A network design for Building\n Pastry Shop Java Application system\nAdobe Photoshop Editing Assignments\nCelonis Academic Process Mining Fundamentals");
                        goback();
                        break;

                    case 3:
                        Console.WriteLine("------Additional Training Attended----");
                        Console.WriteLine("\n->Introduction to GIT\n->CyberSecurity Awareness and Preventions Workshop\n->OpenSap SAP HANA:Fundamentals and insights into Cloud databases.\n->Academic Process Mining Audit Professional\n->Academic Process Mining Expert.");
                        goback();
                        break;

                    case 4:
                             finished = true;
                             MainMenu menu2 = new MainMenu();
                             menu2.mainoption();
                             return;
                       
                }
               
            } while (finished != true);


        }
        
        public static void goback()
        {
            Console.WriteLine("\nPress enter to go back to main menu");
            Console.ReadKey();
            MainMenu menu1 = new MainMenu();
            menu1.mainoption();
            return;

        }


    }
    
    }
