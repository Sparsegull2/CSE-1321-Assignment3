/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment3B
*/

using System;

class Assignment3B
{

    public static void Main(string[] args)
    {
        Console.WriteLine("[World Traveler Checklist]");
        Console.Write("Have you been to Africa? ");
        char africa= char.Parse(Console.ReadLine());
        Console.Write("Have you been to Antarctica? ");
        char antartica = char.Parse(Console.ReadLine());
        Console.Write("Have you been to Asia? ");
        char asia = char.Parse(Console.ReadLine());
        Console.Write("Have you been to Australia? ");
        char australia = char.Parse(Console.ReadLine());
        Console.Write("Have you been to Europe? ");
        char europe = char.Parse(Console.ReadLine());
        Console.Write("Have you been to North America? ");
        char N_america = char.Parse(Console.ReadLine());
        Console.Write("Have you been to South America? ");
        char S_america = char.Parse(Console.ReadLine());
        int count = 0;
        switch(africa) 
        {
            case 'Y':
            count++;
                break;
        }
        switch(antartica )
        {
            case 'Y':
            count++;
                break;
        }
       switch(asia)
        {
            case 'Y':
            count++;
                break;
        }
        switch (australia)
        {
            case 'Y':
            count++;
                break;
        }
        switch (europe)
        {
            case 'Y':
            count++;
                break;
        }
        switch (N_america)
        {
            case 'Y':
            count++;
                break;
        }
        switch(S_america)
        {
            case 'Y':
            count++;
                break;
        }
        switch (count)
        {
            case 0:
                Console.WriteLine("\nYou have visited"+count+ "continents: How is that possible? Are you living in space?");
                break;
            case 1: 
                Console.WriteLine("\nYou have visited"+count+ "continent: That’s a good start. Time to explore the world!");
                break;
            case 2:
            case 3:
                Console.WriteLine("\nYou have visited"+count+ "continents: You’ve just started your journey to see the world.");
                break;
            case 4:
            case 5:
                Console.WriteLine("\nYou have visited"+count+ "continents: You’re an experienced traveler now.");
                break;
            case 6:
                Console.WriteLine("\nYou have visited"+count+ "continents: Wow, you’ve been almost everywhere!");
                break;
            case 7:
                Console.WriteLine("\nYou have visited"+count+ "continents: You’re a true world traveler!");
                break;
        }
    }
}
