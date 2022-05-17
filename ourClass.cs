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
			byte[] asciiValues = Encoding.ASCII.GetBytes(unencrypted);

			string temp = asciiValues.ToString();

			Console.WriteLine(temp);
			Console.ReadLine();

			return temp;
		}

	
		public static string Decrypt( String encrypted)
		{
			string decrypted = string.Empty;
			byte[] decryptedBytes = Encoding.ASCII.GetBytes(encrypted);	



			return decrypted;
		}
	}
}
