namespace GettingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Hello, what is your name?: ");
            //string name = Console.ReadLine();
            //Console.Write("How old are you?:");
            //string age = Console.ReadLine();
            //Console.WriteLine("Hello " + name + ", you are: " + age);


            Console.WriteLine("Hello, Welcome to --Create your own story!---");
            Console.WriteLine("Firstly, lets create your character!");
            Console.Write("What is your hero's name? ");
            string name = Console.ReadLine();
            Console.Write("Where do you hail from? ");
            string home = Console.ReadLine();
            Console.WriteLine("Welcome " + name + ", hero of " + home + "!");
            Console.WriteLine("You were having a mug of mead in the tavern of " + home + " when you were asked to recount your legendary\nencounter with the orc warchief, Balzagh");
            Console.Write("What was the name of your weapon? ");
            string weapon = Console.ReadLine();
            Console.Write("How many orcs did you slay? ");
            string kills = Console.ReadLine();
            Console.WriteLine("You valiantly tell the tale of how you killed " + kills + " fiendish orcs with your mighty weapon, " + weapon);



            Console.ReadLine();
        }
    }
}
