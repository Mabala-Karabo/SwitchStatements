namespace SwitchStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                //int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("The cube of the number you have enetered is: ");
                //Console.WriteLine("The cube of the number you have enetered is: ");//notice the difference
                Console.WriteLine(Cube(num1));


                //freeze code
                Console.ReadLine();
            }
            static int Cube(int num1)
            {
                return num1 * num1 * num1;
            }
        }
    }
}
