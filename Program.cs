
//Write a program to print numbers from n to 1 using recursion

//backwards previous assignment

namespace Assignment_5._2_Question_3
{
    internal class Program
    {
        static void Main()
        {
            //input
            Console.Write("Please enter any number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The numbers backwards from " + n + " to 1 are:");
            recursion(n);
        }

        static void recursion(int n)
            {
                if (n == 0)
                {
                    return;
                }

                Console.Write(n + " ");

                recursion(n - 1);
            }


    }
}

