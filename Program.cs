// mohammad mahdi almasi
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Answer Question");
        string answer = Console.ReadLine();
        if (answer.ToLower() == "yes")
        {
            //ask second question
            Console.WriteLine("Second Question");
            string answer2y = Console.ReadLine();
            if (answer2y.ToLower() == "yes")
            {
                //ask third question 
                //...
            }
            else if (answer2y.ToLower() == "no")
            {
                //ask third question
                //...
            }

        }
        else if (answer.ToLower() == "no")
        {
            //ask second question if the privious question was no
            Console.WriteLine("Answer Question that you said no");
            string answer2n = Console.ReadLine();
            if (answer2n.ToLower() == "yes")
            {
                //ask third question 
                //...
            }
            else if (answer2n.ToLower() == "no")
            {
                //ask third question
                //...
            }

        }
    }
}
