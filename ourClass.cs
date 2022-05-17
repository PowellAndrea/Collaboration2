using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaboration
{
	internal class ourClass
	{

		public Encoding asciiEncoding = Encoding.ASCII;

		Dictionary<int,int> SpyStuff = new Dictionary<int,int>();

		public void buildSpyStuff()
		{
			SpyStuff.Add(2, 9);
		}

		/* The encryption/decryption methods
		 * must use some form of sum of all ASCII values
		 * as a (partial) basis/start point for encrypting the string.
		 */

		public static string Encrypt(String unencrypted)
		{
			char[] chars = unencrypted.ToCharArray();
			int count = 0;
			byte[] asciiValues = Encoding.ASCII.GetBytes(unencrypted);
			byte[] byteMe = new byte[100];

			string stringOutput = asciiValues.ToString();

			// copy first ASCII byte & append it to the last byte of the temp string
			foreach (byte value in asciiValues)
			{
				byteMe.Append(value);
				count++;
			}

			stringOutput = byteMe.ToString();

			var m = Encoding.ASCII.GetString(byteMe);



			// Add length of string to the last byte in the array




			return stringOutput;
		}
	}
}
