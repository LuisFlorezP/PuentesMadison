using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuentesMadison
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Bridge bridge = new Bridge();

                Console.Write("Enter the bridge: ");
                bridge.Structure = Console.ReadLine();

                bridge.ProveBridge();

                Console.WriteLine($"Bridge: {bridge.Structure} is valid.");
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
            }
            Console.Write("Press a key to end... ");
            Console.ReadKey();
        }
    }
}
