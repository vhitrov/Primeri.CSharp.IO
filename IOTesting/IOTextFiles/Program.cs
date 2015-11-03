﻿using System;

namespace IOTextFiles
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			STable _STable = new STable ();
			IOSettings _io = new IOSettings (_STable);

			Console.WriteLine (_STable.stable [0]);
			Console.WriteLine (_STable.stable [1]);
			Console.WriteLine (_STable.stable [2]);
			Console.WriteLine (_STable.stable [3]);

			if (_io.save ()) {
				Console.WriteLine ("Таблицата е запаметена успешно.");
			} else {
				Console.WriteLine ("Таблицата НЕ е запаметена успешно.");
			}
		}
	}
}
