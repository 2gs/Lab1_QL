using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double l, w = 0;
            double area, perimeter;
            string answer;
            bool cont = true;
            while (cont == true)
            {


                //input
                        Console.WriteLine("Enter Length");
                        l = int.Parse(Console.ReadLine());


                        Console.WriteLine("Enter Width");
                        w = int.Parse(Console.ReadLine());

                        area = l * w;
                        perimeter = (2 * l) + (2 * w);

                        Console.WriteLine("The area is" + " " + area);
                        Console.WriteLine("The perimeter is" + " " + perimeter );

                        Console.WriteLine("\n" + "Do you want to continute Y or N ????");
                        answer = Console.ReadLine().ToUpper();
                        if( answer == "Y")
                        {
                    cont = true;
                            
                        }
                        else if( answer =="N")
                        {
                    cont = false;
                        }

                        
                }
            }




        }
    }

