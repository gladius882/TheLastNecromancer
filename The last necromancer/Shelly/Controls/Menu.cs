/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-08
 * Time: 14:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Shelly.Controls
{
	/// <summary>
	/// Description of Menu.
	/// </summary>
	public class Menu
	{
		private List<MenuOption> Options = new List<MenuOption>();
		private int MarkedIndex = 0;
		
		public int X = 0;
		public int Y = 0;
		public int LineSpacing = 1;
		public ConsoleColor ActiveColor = ConsoleColor.White;
		
		public Menu()
		{
			
		}
		
		public void AddOption(MenuOption opt)
		{
			this.Options.Add(opt);
		}
		
		public int Show()
		{
			while(true)
			{	
				this.DisplayMenu();
				
				ConsoleKeyInfo key = Console.ReadKey(true);
				
				if(key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.W)
				{
					if(MarkedIndex == 0)
						MarkedIndex = this.Options.Count-1;
					else
						MarkedIndex--;
				}
				else if(key.Key == ConsoleKey.DownArrow || key.Key == ConsoleKey.S)
				{
					if(MarkedIndex == this.Options.Count-1)
						MarkedIndex = 0;
					else
						MarkedIndex++;
				}
				else if(key.Key == ConsoleKey.Enter)
					return MarkedIndex;
				
			}
		}
		
		private void DisplayMenu()
		{
			int pos = 0;
			int index = 0;
			
			foreach(MenuOption opt in this.Options)
			{	
				ConsoleColor old = Console.ForegroundColor;
				
				if(index == this.MarkedIndex)
					Console.ForegroundColor = this.ActiveColor;
				
				Console.SetCursorPosition(X, Y+pos);
				opt.Show();
				pos += opt.Height+this.LineSpacing;
				
				Console.ForegroundColor = old;
				index++;
			}
		}
	}
}
