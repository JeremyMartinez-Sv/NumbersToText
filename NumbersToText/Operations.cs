namespace NumbersToText
{
    public class Operations
    {
        public static void ChangeLanguage()
        {
            Console.Write(Constants.SelectLanguage);
            if (int.TryParse(Console.ReadLine(), out var result))
            {
                switch (result)
                {
                    case 0:
                        Constants.EnglishLanguage = true;
                        Console.WriteLine(Constants.SelectedLanguage);
                        break;
                    case 1:
                        Constants.EnglishLanguage = false;
                        Console.WriteLine(Constants.SelectedLanguage);
                        break;
                    default:
                        Console.WriteLine(Constants.OutOfRange);
                        break;
                }
            }
            else
            {
                Console.WriteLine(Constants.InvalidInput);
            }
        }

        public static void InitConvert()
        {
            Console.Write(Constants.EnterNumber);
            if (int.TryParse(Console.ReadLine(), out var result))
            {
                if (result >= -9999 && result <= 9999)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(ConvertToWords(result));
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(Constants.OutOfRange);
                }
            }
            else
            {
                Console.WriteLine(Constants.InvalidInput);
            }
        }

        private static string ConvertToWords(int number)
        {
            if (number == 0)
            {
                return Constants.Zero;
            }
            if (number < 0)
            {
                return Constants.Minus + ConvertToWords(-number);
            }
            string text = "";
            if (number / 1000 > 0)
            {
                text = text + ConvertToWords(number / 1000) + Constants.Thousand;
                number %= 1000;
            }
            if (number / 100 > 0)
            {
                text = text + ConvertToWords(number / 100) + (Constants.EnglishLanguage ? Constants.Hundred : ((number > 199) ? Constants.Cientos : ((number == 100) ? Constants.Hundred : Constants.Ciento)));
                number %= 100;
            }
            if (number > 0)
            {
                if (text != "")
                {
                    text += Constants.And;
                }
                if (number < 20)
                {
                    text += Constants.UnitsMap[number];
                }
                else
                {
                    text += Constants.tensMap[number / 10];
                    if (number % 10 > 0)
                    {
                        text = text + " " + Constants.UnitsMap[number % 10];
                    }
                }
            }
            return text;
        }
    }
}
