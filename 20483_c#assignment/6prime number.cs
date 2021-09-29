using System;
using System.Collections.Generic;
using System.Text;

namespace sampleprogram
{
	class prime_number
	{
		public static void Main(string[] args)
		{
			int i, j, p;
			int[] arr = new int[5];

			Console.Write("Enter elements:");
			for (i = 0; i < arr.Length; i++)
			{
				arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			Console.Write("Prime list :");
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
					Console.Write(arr[i] + " ");

				}
				if(arr[0] < arr[i]) 
				{
					arr[0] = arr[i];
					Console.Write(arr[i] + " ");

				}

			}
		}
