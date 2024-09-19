using System.Security.Cryptography.X509Certificates;

namespace Lab2AidenKramer
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
         Console.WriteLine("Hello My Name Is Aiden Kramer And The Date Is 09-13-2024");
            // using Console.WriteLine to print my Introduction and the date.
            
            GameManager manager = new GameManager();
            manager.PlayGame();
            //Game Manager Controls the different states in a game an example in this case is that we are telling the game manager to playGame. 
            
         Console.WriteLine("GoodBye Have A Great Day!!");
            // using Console.WriteLine to print my goodbye message.
        }

    }
}
