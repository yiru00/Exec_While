using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1 + 2 + 3 + 4 + ....+N < 105請問 N 是多少 ?
			//(1+N)*N/2 < 105
			//N+N*N<210

			int start =1; //N=start
			
			while (start+start*start<210)
			{
				start ++;
			}
			Console.WriteLine(start);
			

		}
	}
}
