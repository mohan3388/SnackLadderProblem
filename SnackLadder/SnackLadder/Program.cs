namespace SnackLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Problem problem = new Problem();
            int pos =  problem.DieRoll();
            Console.WriteLine("You got: "+pos);
        }
    }
}