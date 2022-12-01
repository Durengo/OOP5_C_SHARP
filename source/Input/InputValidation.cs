using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP5.source.Input
{
    using OOP5.source.Log;

    public class InputValidation
    {
        public static int GIBI(string input)
        {
            int converted;
            while (true)
            {
                try
                {
                    converted = int.Parse(input);
                    return converted;
                }
                catch (ArgumentNullException e)
                {
                    Log.ERROR(e);
                }
                catch (OverflowException e)
                {
                    Log.ERROR(e);
                }
                catch (FormatException e)
                {
                    Log.ERROR(e);
                }
                catch (Exception e)
                {
                    Log.ERROR(e);
                }
            }
        }

        public static int GIBI(int min, int max, string input)
        {
            while (true)
            {
                int converted = GIBI(input);
                if (converted >= min && converted <= max)
                {
                    return converted;
                }
                else
                {
                    Log.ERROR(
                        $"EXCEPTION! INPUT OUT OF RANGE: {converted} in [MIN]{min}-[MAX]{max}\nTRY AGAIN"
                    );
                }
            }
        }

        public static double GIBD(string input)
        {
            double converted;
            while (true)
            {
                try
                {
                    converted = double.Parse(input);
                    return converted;
                }
                catch (ArgumentNullException e)
                {
                    Log.ERROR(e);
                }
                catch (OverflowException e)
                {
                    Log.ERROR(e);
                }
                catch (FormatException e)
                {
                    Log.ERROR(e);
                }
                catch (Exception e)
                {
                    Log.ERROR(e);
                }
            }
        }

        public static double GIBD(int min, int max, string input)
        {
            while (true)
            {
                double converted = GIBD(input);
                if (converted >= min && converted <= max)
                {
                    return converted;
                }
                else
                {
                    Log.ERROR(
                        $"EXCEPTION! INPUT OUT OF RANGE: {converted} in [MIN]{min}-[MAX]{max}\nTRY AGAIN"
                    );
                }
            }
        }

        public static float GIBF(string input)
        {
            float converted;
            while (true)
            {
                try
                {
                    converted = float.Parse(input);
                    return converted;
                }
                catch (ArgumentNullException e)
                {
                    Log.ERROR(e);
                }
                catch (OverflowException e)
                {
                    Log.ERROR(e);
                }
                catch (FormatException e)
                {
                    Log.ERROR(e);
                }
                catch (Exception e)
                {
                    Log.ERROR(e);
                }
            }
        }

        public static float GIBF(int min, int max, string input)
        {
            while (true)
            {
                float converted = GIBF(input);
                if (converted >= min && converted <= max)
                {
                    return converted;
                }
                else
                {
                    Log.ERROR(
                        $"EXCEPTION! INPUT OUT OF RANGE: {converted} in [MIN]{min}-[MAX]{max}\nTRY AGAIN"
                    );
                }
            }
        }

        public static bool IsWhiteSpace(string text)
        {
            return text.All(c => char.IsWhiteSpace(c));
        }

        public static bool FoundWhiteSpace(string text)
        {
            return text.Any(c => Char.IsWhiteSpace(c));
        }

        public static bool IsLetters(string text)
        {
            return text.All(c => char.IsLetter(c));
        }

        public static bool IsNumbers(string text)
        {
            return text.All(c => char.IsNumber(c));
        }

        public static int CapitalLetterCount(string text)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                    count++;
            }
            return count;
        }

        public static bool NameValidation(string name)
        {
            if (
                name != ""
                && IsLetters(name)
                && CapitalLetterCount(name) == 1
                && !FoundWhiteSpace(name)
            )
            {
                return true;
            }
            else
                return false;
        }
    }
}
