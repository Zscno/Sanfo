using System;

namespace Zscno.Sanfo
{
    internal class GetRandomLetters
    {
        public readonly string[] Letters;

        public GetRandomLetters()
        {
            Letters =
            [
                "a", "b", "c", "d", "e", "f", "g","h", "i", "j", "k", "l", "m", 
                "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            ];
        }

        public string Get(int length)
        {
            string returnText = string.Empty;
            Random random = new();

            for (int i = 1; i < length + 1; i++)
            {
                returnText += Letters[random.Next(0, 25)];
            }

            return returnText;
        }
    }
}