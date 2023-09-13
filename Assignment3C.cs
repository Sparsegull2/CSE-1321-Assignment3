/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment3C
*/

using System;

class Assignment3C
{

    public static void Main(string[] args)
    {
        Console.WriteLine("[Guess the Color Mode]");
        Console.Write("How many channels does your image have? ");
        int channel = int.Parse(Console.ReadLine());
        switch (channel)
        {
            case 1:
            case 2:
                Console.WriteLine("It is a Grayscale image.");
                break;
            case 3:
                Console.WriteLine("It is an RGB image.");
                break;
            case 4:
                Console.Write("What is its BPC value? ");
                int BPC = int.Parse(Console.ReadLine());
                if (BPC == 32) { Console.WriteLine("It is an RGB image."); }
                else if (BPC == 16 || BPC == 8)
                {
                    Console.Write("What image format is it? ");
                    string format = Console.ReadLine();
                    if (format == "TIFF") Console.WriteLine("It is a CMYK image.");
                    if (format == "BMP") Console.WriteLine("This image’s color mode can not be determined.");
                    if (format == "PNG") Console.WriteLine("It is an RGB image.");
                    else Console.WriteLine("This is invalid input. Please run the program again.");
                }
                else Console.WriteLine("This is invalid input. Please run the program again.");
                break;
            case 5:
                Console.WriteLine("It is a CMYK image.");
                break;
            default:
                Console.WriteLine("This is invalid input. Please run the program again.");
                break;
        }
    }
}