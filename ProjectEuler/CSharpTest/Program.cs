using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
	using System.Diagnostics;

	internal class Program
	{
		private static void Main(string[] args)
		{		
			PrimeFactorTest();

			Console.ReadLine();
		}

		private static void PrimeFactorTest()
		{		
			var sw = Stopwatch.StartNew();
			
			var result2 = prime(600851475143);

			sw.Stop();
			Console.WriteLine(sw.ElapsedMilliseconds + " in ms");

			result2.ForEach(Console.WriteLine);
		}

		//http://www.hsg-kl.de/faecher/inf/algorithmus/standard/primfak/index.php
		private static List<int> prime(Int64 n)
		{
			var primeList = new List<int>();

			while ((n % 2) == 0)
			{
				primeList.Add(2);
				n = n / 2;
			}

			while ((n % 3) == 0)
			{
				primeList.Add(3);
				n = n / 3;
			}

			var t = 5;
			var dif = 2;

			while ((t * t) <= n)
			{
				while ((n % t) == 0)
				{
					primeList.Add(t);
					n = n / t;
				}

				t = t + dif;
				dif = 6 - dif;
			}

			if(n > 1)
				primeList.Add(Convert.ToInt32(n));

			return primeList;
		}

		private static void SieveTest()
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
