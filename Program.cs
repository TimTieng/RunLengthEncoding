using System;
using System.Text;


namespace RunLengthEncoding {
    class Program {
        public static void Main(string[] args) {
            //
            string test1 = "AAAAABBBBCCCCCCCCCCCCCCCCCDDDDE";
            RunLengthEncoder(test1);
        }
        public static string RunLengthEncoder(string str) {
            // Create an instance of the Stringbuilder class
            StringBuilder encodedString = new StringBuilder();
            // Input String will be at least lenght of 1
            // Declare and Init a running variable to be updated
            int currentRunCount = 1;

            for (int i = 1; i < str.Length; i++) {
                // Declare and Init variables holding current chars to be compared 
                char currentChar = str[i];
                char previousChar = str[i-1];

                // Evaluate if they are not equal or the currentRunCount == 9 to conduct split naming
                if ((currentChar != previousChar) || (currentRunCount == 9)) {
                    // Append the current runcount to the encodedString instance - Casting Required
                    encodedString.Append(currentRunCount.ToString());
                    // Append previousChar to encodedString because count will be reset at current char
                    encodedString.Append(previousChar);
                    // Reset count because the length is over 10 for the current char
                    currentRunCount = 0;
                }
                // increment run count for next char
                currentRunCount++;
            }
            // Append for the remainder of the input string both runcount and current char of the string
            encodedString.Append(currentRunCount.ToString());
            encodedString.Append(str[str.Length -1]);

            return encodedString.ToString(); 
        }
    }
}
