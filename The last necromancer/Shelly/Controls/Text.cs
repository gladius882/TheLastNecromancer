/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-05
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Shelly.Controls
{
	/// <summary>
	/// Description of Text.
	/// </summary>
	public class Text : ConsoleControl
	{
		public string Caption = "";
		public Aligment Aligment = Aligment.Left;
		
		public override int Width {get; set;}
		public override int Height {get; set;}
		public override int X {get; set;}
		public override int Y {get; set;}
		public int Padding = 0;
		
		public Text()
		{
			this.X = 0;
			this.Y = 0;
			this.Width = 20;
			this.Height = 10;
		}
		
		public void Show(int x, int y)
		{
			this.X = x;
			this.Y = y;
			this.Show();
		}
		
		public override void Show()
		{
			string[] words = Caption.Split(' ');
			int charsPerLine = Width-(2*Padding);
			
			int CursorLeft = X+Padding;
			int CursorTop = Y+Padding;
			Console.SetCursorPosition(CursorLeft, CursorTop);
			
			int charsLeft = charsPerLine;
			string line = "";
			int lineNum = 0;
			
			foreach(string word in words)
			{
				if(word.Length <= charsLeft)
				{
					line += word + " ";
					charsLeft -= word.Length+1;
				}
				else
				{
					line = line.Trim();
					if(Aligment == Aligment.Center)
					{
						Console.SetCursorPosition(CursorLeft+((charsPerLine-line.Length)/2), CursorTop+lineNum);
					}
					Console.Write(line);
					line = "";
					lineNum++;
					charsLeft = charsPerLine;
					Console.SetCursorPosition(CursorLeft, CursorTop+lineNum);
				}
			}
			if(Aligment == Aligment.Center)
			{
				Console.SetCursorPosition(CursorLeft+((charsPerLine-line.Length)/2), CursorTop+lineNum);
			}
			Console.Write(line);
		}
	}
	
	public enum Aligment
	{
		Left,
		Right,
		Center
	}
}
