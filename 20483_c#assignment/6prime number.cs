using System;
using System.Collections.Generic;
using System.Text;

namespace sampleprogram
{
	class prime_number
	{
		public static void Main(string[] args)
		{
			int i, j, p, k, big;
			int[] arr = new int[10];
			int[] primee = new int[10];
			k = 0;
			big = 0;
			Console.Write("Enter array elements:");
			for (i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}


			Console.Write("All Prime List:");
			for (i = 0; i < arr.Length; i++)
			{
				j = 2;
				p = 1;
				while (j < arr[i])
				{
					if (arr[i] % j == 0)
					{
						p = 0;
						break;
					}
					j++;
				}


				if (p == 1)
				{
					primee[k] = arr[i];
					k++;
					Console.WriteLine(arr[i]);

				}
			}
			for (i = 0; i < primee.Length; ++i)
			{
				if (primee[i] > big)
				{
					big = primee[i];
				}
			}
			Console.WriteLine("big:");
			
		}
	}
}
