namespace NBinary
{

    class Program
    {

        public static string finalbinary;
        static void Main()
        {
            Console.WriteLine("Enter a number between 1-147,483,647");
            int nNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You entered: " + nNumber + "\n" + "Correct? Y/N");
            char selection = Convert.ToChar(Console.ReadLine());


            if (selection is 'Y' or 'y')
            {
                bool stackflag = false;

                Stack<int> remainders = new Stack<int>();
                while (stackflag != true)
                {
                    int nMain = nNumber;
                    int nRemainder;
                    while (nMain > 1)
                    {

                        nRemainder = nMain % 2;
                        if (nRemainder == 1)
                        {
                            nMain = (nMain - 1) / 2;
                            remainders.Push(1);
                        }
                        else
                        {
                            nMain = nMain / 2;
                            remainders.Push(0);
                        }
                    }
                    remainders.Push(1);
                    stackflag = true;
                }


                Console.WriteLine("----------------------------------");
                Console.WriteLine(nNumber + " in binary is:");
                Console.WriteLine("{0}", string.Join("", remainders)); // writeline

                foreach (int number in remainders)                     //itteration + print
                {
                    finalbinary += number;
                    //Console.WriteLine(number.ToString());
                }


                int val = 0;
                var result = new List<int>();
                foreach (var b in finalbinary)
                {
                    if (b.Equals('0'))
                    {
                        val += 1;
                    }
                    else
                    {
                        result.Add(val);
                        val = 0;
                    }
                }

                Console.WriteLine("The binary gap is:");
                Console.WriteLine(result.Max());
                Console.WriteLine("----------------------------------");
            }
            else if (selection is 'N' or 'n')
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }


    }
}

