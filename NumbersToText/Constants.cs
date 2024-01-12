namespace NumbersToText
{
    public class Constants
    {
        public static bool EnglishLanguage = true;
        
        public static string Menu => EnglishLanguage ? MenuEN : MenuES;

        public static string[] UnitsMap => EnglishLanguage ? unitsEN : unitsES;

        public static string[] tensMap => EnglishLanguage ? tensEN : tensES;

        public static string Zero => EnglishLanguage ? "Zero" : "Cero";

        public static string Minus => EnglishLanguage ? "Minus " : "Menos ";

        public static string Hundred => EnglishLanguage ? " Hundred " : " Cien ";

        public static string Cientos => " Cientos ";

        public static string Ciento => " Ciento ";

        public static string Thousand => EnglishLanguage ? " Thousand " : " Mil ";

        public static string And => EnglishLanguage ? "and " : "y ";

        public static string EnterNumber => EnglishLanguage ? "Enter an integer between -9999 and 9999: " : "Ingrese un entero entre -9999 y 9999: ";

        public static string OutOfRange => EnglishLanguage ? "Please enter a number within the specified range." : "Por favor ingrese un numero dentro del rango especificado.";

        public static string InvalidInput => EnglishLanguage ? "Invalid input. Please enter a valid integer." : "Entrada inválida. Por favor ingrese un número entero válido.";

        public static string SelectLanguage => EnglishLanguage ? "0 for English, 1 for Spanish\nPlease select a language: " : "0 para Ingles, 1 para Español\nPor favor seleccione un lenguaje: ";

        public static string SelectedLanguage => EnglishLanguage ? "Language set to English" : "Idioma establecido en español";

        private static string MenuEN => "1- Convert number to text (continue entering numbers)\n2- Change language (change the language)\n3- Exit (close the console)\nSelect an option: ";

        private static string MenuES => "1- Convertir número a texto (continuar ingresando números)\n2- Cambiar idioma (cambiar el idioma)\n3- Salir (cerrar la consola)\nSelecciona una opción: ";
        
        private static string[] unitsEN =
        [
            "",
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Eleven",
            "Twelve",
            "Thirteen",
            "Fourteen",
            "Fifteen",
            "Sixteen",
            "Seventeen",
            "Eighteen",
            "Nineteen"
        ];

        private static string[] tensEN =
        [
            "",
            "",
            "Twenty",
            "Thirty",
            "Forty",
            "Fifty",
            "Sixty",
            "Seventy",
            "Eighty",
            "Ninety"
        ];

        private static string[] unitsES =
        [
            "",
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinco",
            "Seis",
            "Siete",
            "Ocho",
            "Nueve",
            "Diez",
            "Once",
            "Doce",
            "Trece",
            "Catorce",
            "Quince",
            "Dieciséis",
            "Diecisiete",
            "Dieciocho",
            "Diecinueve"
        ];

        private static string[] tensES =
        [
            "",
            "",
            "Veinte",
            "Treinta",
            "Cuarenta",
            "Cincuenta",
            "Sesenta",
            "Setenta",
            "Ochenta",
            "Noventa"
        ];
    }
}
