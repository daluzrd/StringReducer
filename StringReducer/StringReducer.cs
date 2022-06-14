using System;
using System.Text.RegularExpressions;

namespace StringReducer
{
    public static class StringReducer
    {
        public static bool IsInputValid(string input) =>
            !(string.IsNullOrEmpty(input) || Regex.IsMatch(input, "[^a-c]"));

        public static char ReplaceEquals(char character1, char character2)
        {
            if (character1 == 'a' && character2 == 'b')
                return 'c';
            else if (character1 == 'a' && character2 == 'c')
                return 'b';
            else if (character1 == 'b' && character2 == 'a')
                return 'c';
            else if (character1 == 'b' && character2 == 'c')
                return 'a';
            else if (character1 == 'c' && character2 == 'a')
                return 'b';
            else
                return 'a';
        }

        public static string Reduce(string input, bool wasRepetition = false)
        {
            if (!IsInputValid(input))
                throw new Exception("Text inputed is out of the norm");
            else if (Regex.IsMatch(input, $"[a]{{{input.Length}}}|[b]{{{input.Length}}}|[c]{{{input.Length}}}"))
                return input;
            else if (input.Substring(0, 1) == input.Substring(1, 1))
            {
                string rest = Reduce(input.Substring(1), true);

                if (wasRepetition)
                    return input.Substring(0, 1) + rest;

                return Reduce(input.Substring(0, 1) + rest);
            }

            char replacedCharacter = ReplaceEquals(input[0], input[1]);

            if (wasRepetition)
                return replacedCharacter + input.Substring(2);

            return Reduce(replacedCharacter + input.Substring(2));
        }
    }
}
