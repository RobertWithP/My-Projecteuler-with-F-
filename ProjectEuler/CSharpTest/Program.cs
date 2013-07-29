using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
	using System.Diagnostics;

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Sieve(10) == 17 ? "Correct" : "Failed");

			var sw = Stopwatch.StartNew();
			Console.WriteLine(Sieve(2000000));

			sw.Stop();
			Console.WriteLine(sw.ElapsedMilliseconds + " in ms");

			sw.Restart();
			Console.WriteLine(SieveOfErastosthenes(2000000));

			sw.Stop();
			Console.WriteLine(sw.ElapsedMilliseconds + " in ms");

			Console.ReadLine();
		}

		private static long Sieve(int p)
		{
			var m = new bool[p + 1];
			long ret = 0;
			for (long i = 2; i <= p; i++)
			{
				if (m[i] == false)
				{
					for (long j = (i * 2); j <= p; j+=i)
					{
							m[j] = true;												
					}

					ret += i;
				}				
			}

			return ret;
		}

		private static long SieveOfErastosthenes(long maxvalue)
		{
			long[] values = new long[maxvalue];
			// Populate the list
			for (long i = 0; i < values.LongLength; ++i)
			{
				values[i] = i;
			}
			values[0] = 0;
			values[1] = 0;
			for (long i = 2; i < values.LongLength; ++i)
			{
				if (values[i] != 0)
				{
					for (long j = i * 2; j < values.LongLength; j += i)
					{
						values[j] = 0;
					}
				}
			}

			long retval = 0;
			foreach (long k in values)
			{
				retval += k;
			}
			return retval;
		}
	}
}
