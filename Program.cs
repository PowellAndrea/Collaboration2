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
			Console.WriteLine(ourClass.Encrypt("Goat"));

		}
	}
}
