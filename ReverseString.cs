
using System;
using System.Text;
namespace ProgramingOnlineTest
{
    public class ReverseString
    {
        public static void Main()
        {
            string strInput = "abcdef";
            string reverseStrOutput = "";

            StringBuilder sb = new StringBuilder();

            char[] intputChars =  strInput.ToCharArray();

            for(int i=strInput.Length-1;i>=0;i--)
            {
                sb.Append(intputChars[i]);
            }

            reverseStrOutput = sb.ToString();

            Console.Write("Reverse of abcdef is: " + reverseStrOutput);

            Console.ReadLine();
        }
    }
}
