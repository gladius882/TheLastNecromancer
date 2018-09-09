/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-02
 * Time: 13:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace Shelly.Controls
{
	/// <summary>
	/// Description of AImage.
	/// </summary>
	public class AImage : ConsoleControl
	{
		private List<GraphicalChar> Characters = new List<GraphicalChar>();
		private int _width;
		private int _height;
		
		public override int Width
		{
			get {
				return this._width;
			}
			set {
				// TODO
			}
		}
		public override int Height
		{
			get {
				return this._height;
			}
			set {
				// TODO
			}
		}
		
		public override int X {get; set;}
		public override int Y {get; set;}
		
		public AImage()
		{
			this.X = 0;
			this.Y = 0;
		}
		
		public void LoadFromFile(string fileName)
		{
			string content = File.ReadAllText(fileName);
			string header = content.Substring(0, 6);
			string pixels = content.Substring(6);
			
			this.Width = int.Parse(header.Substring(0, 3));
			this.Height = int.Parse(header.Substring(3, 3));
			
			try {
				for(int i=0; i<pixels.Length; i+=3)
				{
					GraphicalChar pixel = GraphicalChar.Parse(pixels.Substring(i, 3));
					this.Characters.Add(pixel);
				}
			}
			catch {
				
			}
		}
		
		public void Show(int x, int y)
		{
			this.X = x;
			this.Y = y;
			this.Show();
		}
		
		public override void Show()
		{
			Console.SetCursorPosition(this.X, this.Y);
			ConsoleColor oldBackground = Console.BackgroundColor;
			ConsoleColor oldForeground = Console.ForegroundColor;
			int left = Console.CursorLeft;
			int top = Console.CursorTop;
			
			int x = 0;
			int y = 0;
			for(int i=0; i<this.Characters.Count; i++)
			{
				
				Console.SetCursorPosition(left+x, top+y);
				Console.BackgroundColor = this.Characters[i].Backround;
				Console.ForegroundColor = this.Characters[i].Foreground;
				Console.Write(this.Characters[i].Character);
				
				if(x == this.Width-1)
				{
					x = 0;
					y++;
				}
				else
					x++;
			}
			
			Console.BackgroundColor = oldBackground;
			Console.ForegroundColor = oldForeground;
		}
	}
	
	struct GraphicalChar
	{
		public ConsoleColor Backround;
		public ConsoleColor Foreground;
		public char Character;
		
		public static GraphicalChar Parse(string str)
		{
			GraphicalChar result;
			result.Backround = GraphicalChar.CodeToColor(str[0]);
			result.Foreground = GraphicalChar.CodeToColor(str[1]);
			result.Character = str[2];
			return result;
		}
		
		public static ConsoleColor CodeToColor(char code)
		{
			if(code == '0') return ConsoleColor.Black;
			if(code == '1') return ConsoleColor.DarkBlue;
			if(code == '2') return ConsoleColor.DarkGreen;
			if(code == '3') return ConsoleColor.DarkCyan;
			if(code == '4') return ConsoleColor.DarkRed;
			if(code == '5') return ConsoleColor.DarkMagenta;
			if(code == '6') return ConsoleColor.DarkYellow;
			if(code == '7') return ConsoleColor.Gray;
			if(code == '8') return ConsoleColor.DarkGray;
			if(code == '9') return ConsoleColor.Blue;
			if(code == 'A') return ConsoleColor.Green;
			if(code == 'B') return ConsoleColor.Cyan;
			if(code == 'C') return ConsoleColor.Red;
			if(code == 'D') return ConsoleColor.Magenta;
			if(code == 'E') return ConsoleColor.Yellow;
			if(code == 'F') return ConsoleColor.White;
			
			throw new ArgumentOutOfRangeException(code + " is not a color code (values from 0 to F expected).");
		}
	}
}
