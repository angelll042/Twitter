using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Enter your message: ");
        string userMessage = Console.ReadLine();

        if (userMessage.Length <= 140)
        {
            Console.WriteLine("Posted");
        }
        else
        {
            Console.WriteLine("Rejected.");
        }
    }
}