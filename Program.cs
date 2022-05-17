using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collaboration
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ourClass test = new ourClass();
			test.buildSpyStuff();
			Console.WriteLine("unencrypted sent was  = Goat");
			Console.WriteLine("encrypted response: " + ourClass.Encrypt("Goat") );
			Console.ReadLine();
		}
	}
}
