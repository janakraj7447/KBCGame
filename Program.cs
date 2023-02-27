using System.Collections;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Questions ques = new Questions();
        var selectQue = ques.GetQuestions();
        var QuesAns = (from q in selectQue select q);

        Random rnd = new Random();
        var randomQues = QuesAns.Skip(rnd.Next(9)).Take(9);
        int count = 0;
        Console.WriteLine("Welcome to KBC...");
        Console.WriteLine("Please write your name...");
        string name = Console.ReadLine();
        int RightAns=0;
        Console.WriteLine("Game starts......");
        foreach (var show in randomQues)
        {
            if (count < 2)
            {
                Console.WriteLine(show.Question);
                Console.WriteLine(show.Answer);
                int ans = int.Parse(Console.ReadLine());
                while (ans < 1 || ans > 4)
                {
                    Console.WriteLine("You have entered other option which is not in our scope,please enter your option again between 1 and 4");
                    ans = int.Parse(Console.ReadLine());
                }

                if (show.CorrectAns == ans)
                {
                    Console.WriteLine("Your answer is correct");
                    RightAns++;
                }
                else
                {
                    Console.WriteLine("Incorrect answer");
                    count++;
                   
                }
            }
            else
            {
                break;
            }
        }
        if (count == 2)
        {
            Console.WriteLine("Sorry, you have gave two wrong answers,have a better luck for next time");
        }
        else
        {
            Console.WriteLine("Congratulations, " + name + " you have won the game");
            Console.WriteLine("you have given "+ RightAns +" Right answers");
        }
    }
}
