using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* The encryption/decryption methods
 * must use some form of sum of all ASCII values
 * as a (partial) basis/start point for encrypting the string.
 */


namespace Collaboration
{
	internal class ourClass
	{

		public Encoding asciiEncoding = Encoding.ASCII;

		public static string Decrypt(String encrypted)
		{
			string OutputString = string.Empty;
			
			// Split the encrypted string into sub-strings for each "number word"
			string[] Values = encrypted.Split('*');
			byte[] byteArray;

			var sum = int.Parse(Values.Last()); // grab the last value - this is the sum/key

			for (int index=0; index<Values.Length-1; index++)
			{
				//char[] Values = Values[index].ToCharArray();

				if (Values[index] != Values.Last())
				{
					string x = (int.Parse(Values[index]) / sum).ToString();
					var i = (int.Parse(Values[index]) / sum);
					var c = 

					byte b =Encoding.ASCII.GetBytes(i);

					Console.WriteLine(b);

				}
				//Console.WriteLine(OutputString); // FIX:  Currently returning the a Ascii code for the first int;
			}
			return OutputString;
		}



		public static string Encrypt(String unencrypted)
		{
			char[] charArray = unencrypted.ToCharArray();   // Convert unencrypted string to a character array

			byte[] byteArray = new byte[charArray.Length + 5];  // Create a byteArray the (length of the character array + 5)
			byteArray = Encoding.ASCII.GetBytes(charArray);    // Convert unencrypted string to a byte array

			string OutputString = null;
			int sum = 0;
			//List<int> Values = new List<int>();

			foreach (byte b in byteArray) // each byte = the ascii code for each character in the unencoded string
			{ 
				sum = sum + (Int32)(b); // sum of the number value for each ascii code
			}

			foreach (byte b in byteArray)
			{ 
				OutputString += (b * sum).ToString() + '*';
			}

			OutputString += sum.ToString() ;

			return OutputString;
		}
	}
}
