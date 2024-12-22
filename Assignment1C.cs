
/*
Class: CSE 1321L
Section: W1 C#
Term: Spring 2024
Instructor: Manosmi Gundu
Name: Jaeden Jones
Assignment#: 1
*/






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    public class Assignment1C
{
    public static void Main(string[] args)
    {

       



        Console.WriteLine("How far your donation goes");

        Console.WriteLine("");

        int soup1, bag1, pb1;

        double v1, peep23; 

        string userinput1;
        Console.Write("How many cans of soups? ");
        userinput1= Console.ReadLine();
        int canofsoup = Convert.ToInt32(userinput1);

       
        soup1 = canofsoup * 2;
        

        string userinput2;
        Console.Write("How many bags of rice? ");
        userinput2 = Console.ReadLine();
        int bagorice = Convert.ToInt32(userinput2);

      
        bag1 = bagorice * 4;


        string userinput3;
        Console.Write("How many cans of vegetables? ");
        userinput3 = Console.ReadLine();
        int veggie = Convert.ToInt32(userinput3);


        v1 = veggie * 3.5; 


       string userinput4;
       Console.Write("How many cans of peanut butter? ");
       userinput4 = Console.ReadLine();
       int butter = Convert.ToInt32(userinput4);


        pb1 = butter * 7;


        peep23 = soup1 + bag1 + v1 + pb1;

        Console.WriteLine();


        Console.WriteLine("Your donation will help feed " + peep23 + " people!");

        Console.WriteLine(soup1 + " people with the " + userinput1 + " can(s) of soup");

        Console.WriteLine(bag1 + " people with the " + userinput2 + " bag(s) of rice");

        Console.WriteLine(v1 + " people with the " + userinput3 + " can(s) of vegetables");

        Console.WriteLine(pb1 + " people with the " + userinput4 + " can(s) of peanut butter");

        









    }
}
