using System;

namespace API.Services
{
    public class Essentials
    {
        public static string DigitsToWords (int digit)
        {
            var digitToWords = "";
            switch(digit)
            {
                case 1:
                    digitToWords = "One";
                    break;
                case 2:
                    digitToWords = "Two";
                    break;
                case 3:
                    digitToWords = "Three";
                    break;
                case 4:
                    digitToWords = "Four";
                    break;
                case 5:
                    digitToWords = "Five";
                    break;
                case 6:
                    digitToWords = "Six";
                    break;
                case 7:
                    digitToWords = "Seven";
                    break;
                case 8:
                    digitToWords = "Eight";
                    break;
                case 9:
                    digitToWords = "Nine";
                    break;
                case 0:
                    digitToWords = "";
                    break;
            }

            return digitToWords;
        }

        public static string TeensToWords (int tens)
        {
            var tensText = "";

            switch(tens)
            {
                case 10:
                    tensText = "Ten";
                    break;
                case 11:
                    tensText = "Eleven";
                    break;
                case 12:
                    tensText = "Twelve";
                    break;
                case 13:
                    tensText = "Thirteen";
                    break;
                case 14:
                    tensText = "Fourteen";
                    break;
                case 15:
                    tensText = "Fifteen";
                    break;
                case 16:
                    tensText = "Sixteen";
                    break;
                case 17:
                    tensText = "Seventeen";
                    break;
                case 18:
                    tensText = "Eighteen";
                    break;
                case 19:
                    tensText = "Nineteen";
                    break;
            }

            return tensText;
        }

        public static string TensToWords (int number)
        {
            var tensText = "";
            var tens = 0;
            var singles = 0;

            tens = number / 10;
            singles = number % 10;

            switch(tens)
            {
                case 0:
                    tensText = DigitsToWords (singles);
                    break;
                case 1:
                    tensText = TeensToWords (number);
                    break;
                case 2:
                    tensText = "Twenty";
                    break;
                case 3:
                    tensText = "Thirty";
                    break;
                case 4:
                    tensText = "Forty";
                    break;
                case 5:
                    tensText = "Fifty";
                    break;
                case 6:
                    tensText = "Sixty";
                    break;
                case 7:
                    tensText = "Seventy";
                    break;
                case 8:
                    tensText = "Eighty";
                    break;
                case 9:
                    tensText = "Ninety";
                    break;
            }

            if(tens > 1)
            {
                if (singles != 0)
                    tensText += " ";
                tensText += DigitsToWords (singles);
            }

            return tensText;
        }

        public static string HundredToWords(int number)
        {
            var hundredsText = "";
            if(number == 0)
                return hundredsText;

            var tensPart = number % 100;
            var hundredPart = number / 100;

            switch(hundredPart)
            {
                case 0:
                    hundredsText = TensToWords (tensPart);
                    break;
                default:
                    hundredsText = DigitsToWords (hundredPart) + " Hundred";
                    if(tensPart != 0)
                        hundredsText += " And ";
                    hundredsText += TensToWords (tensPart);
                    break;
            }

            return hundredsText;
        }

        public static string MillsToWords(int number)
        {
            var hundredsText = "";
            if(number == 0)
                return hundredsText;

            var single = number % 10;
            Console.WriteLine (single);

            hundredsText = DigitsToWords (single);

            return hundredsText;
        }

        public static string ThousandsToWords (int number)
        {
            var thousandsText = "";
            var thousandPart = 0;
            var hundredPart = 0;

            hundredPart = number % 1000;
            thousandPart = number / 1000;

            thousandsText += HundredToWords(thousandPart);

            if(thousandPart != 0)
                thousandsText += " Thousand";

            if(hundredPart > 99)
            {
                if(hundredPart != 0 && thousandPart != 0)
                    thousandsText += " ";
                thousandsText += HundredToWords (hundredPart);
            }
            else
            {
                if(hundredPart != 0 && thousandPart != 0)
                    thousandsText += " And ";
                thousandsText += HundredToWords (hundredPart);
            }

            return thousandsText;
        }

        public static string MillionsToWords (int number)
        {
            var millionText = "";
            var millionPart = number / 1000000;
            var thousandPart = number % 1000000;

            millionText += HundredToWords (millionPart);

            if(millionPart != 0)
                millionText += " Million";

            if(thousandPart > 99)
            {
                if(thousandPart != 0 && millionPart != 0)
                    millionText += " ";
                millionText += ThousandsToWords (thousandPart);
            }
            else
            {
                if(thousandPart != 0 && millionPart != 0)
                    millionText += " And ";
                millionText += ThousandsToWords (thousandPart);
            }

            return millionText;
        }

        public static string BillionToWords (long number)
        {
            var billionText = "";
            var billionPart = (int)(number / 1000000000);
            var millionPart = (int)(number % 1000000000);

            billionText += HundredToWords (billionPart);

            if(billionPart != 0)
                billionText += " Billion";

            if(millionPart > 99)
            {
                if(millionPart != 0 && billionPart != 0)
                    billionText += " ";
                billionText += MillionsToWords (millionPart);
            }
            else
            {
                if(millionPart != 0 && billionPart != 0)
                    billionText += " And ";
                billionText += MillionsToWords (millionPart);
            }

            return billionText;
        }

        public static string TrillionToWords (long number)
        {
            var trillionText = "";
            var trillionPart = (int)(number / 1000000000);
            var billionPart = number % 1000000000;

            if(trillionPart > 999)
            {
                trillionText += "One Quadrillion";
                return trillionText;
            }

            trillionText += HundredToWords (trillionPart);

            if(trillionPart != 0)
                trillionText += " Trillion";

            if(billionPart > 99)
            {
                if(billionPart != 0 && trillionPart != 0)
                    trillionText += " ";
                trillionText += BillionToWords (billionPart);
            }
            else
            {
                if(billionPart != 0 && trillionPart != 0)
                    trillionText += " And ";
                trillionText += BillionToWords (billionPart);
            }

            return trillionText;
        }

        public static string NumberToWords (double number)
        {
            var numberText = "";
            var wholePartText = "";

            if (number < 0)
            {
                number = number * -1;
                numberText += "Negative ";
            }

            double decimalPart = number - Math.Truncate(number);
            long wholePart = Convert.ToInt64(number);

            wholePartText = TrillionToWords (wholePart);
            numberText += wholePartText;
            if (wholePartText == "One")
            {
                numberText += " Dollar";
            }
            else
            {
                if(wholePartText.Length > 0)
                    numberText += " Dollars";
            }
            
            if(decimalPart != 0)
            {
                if(wholePartText.Length > 0)
                    numberText += " And ";

                numberText += TensToWords((int)(decimalPart * 100));
                numberText += " Cents";

                double mills = (decimalPart + .0001) * 1000;
                

                if(MillsToWords((int)(mills)).Length > 0)
                {
                    numberText += " And ";
                    numberText += MillsToWords((int)(mills));
                    numberText += " Mills";
                }
            }
            
            return numberText.ToUpper();
        }

    }
}