/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment3A
*/

using System;

class Assignment3A
{

    public static void Main(string[] args)
    {
        Console.WriteLine("[WebMD Checker]");
        Console.Write("What is your suspected illness? ");
        string disease= Console.ReadLine();
        if (disease == "HGPS")
        {
            Console.Write("Do you have brittle bones? ");
            char bones = char.Parse(Console.ReadLine());
            if (bones == 'Y')
            {
                Console.WriteLine("It is possible that you have HGPS");
            }
            else if(bones=='N')
            {
                Console.WriteLine("It is not likely that you have HGPS");
            }
        }
        else if(disease== "Bokter Syndrome")
        {
             Console.Write("Do you have a Vitamin C deficiency? ");
            char VC= char.Parse(Console.ReadLine());
            if (VC == 'Y')
            {
                Console.Write("Are you a sailor? ");
                char sailor= char.Parse(Console.ReadLine());
                if(sailor == 'Y')
                {
                    Console.WriteLine("It is possible you have Bokter Syndrome");
                }
                else if (sailor == 'N')
                {
                    Console.WriteLine("It is not likely you have Bokter Syndrome");
                }
            }
            else if(VC == 'N')
            {
                Console.WriteLine("It is not likely that you have Bokter Syndrome");
            }
        }
        else if (disease == "Lupus")
        {
            Console.WriteLine("It is not likely that you have Lupus");
        }
    }
}
