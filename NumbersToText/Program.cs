namespace NumbersToText
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            InitProgram();
        }

        public static void InitProgram()
        {
            while (true)
            {
                Console.Write(Constants.Menu);
                if (int.TryParse(Console.ReadLine(), out var result))
                {
                    Console.WriteLine();
                    switch (result)
                    {
                        case 1:
                            Operations.InitConvert();
                            break;
                        case 2:
                            Operations.ChangeLanguage();
                            break;
                        case 3:
                            return;
                        default:
                            Console.WriteLine(Constants.OutOfRange);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine(Constants.InvalidInput);
                }
                Console.WriteLine();
            }
        }
    }

}
