﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//使用 while , 在畫面顯示所有可以整除 300 的整數例如: 1, 2, 3, 4, 5, 6, 10, ...., 300
			int start = 1;
			int end = 300;
			while (start < 300) 
			{
				if(300%start == 0)
				{
					Console.WriteLine(start);
				}
				start++;
			}
		}
	}
}
