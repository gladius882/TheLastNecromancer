/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-04
 * Time: 11:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Shelly.Controls
{
	/// <summary>
	/// Display a frame made from characters
	/// </summary>
	public class Frame : ConsoleControl
	{
		public char LeftFrame = '#';
		public char RightFrame = '#';
		public char TopFrame = '#';
		public char BottomFrame = '#';
		public char Frames
		{
			set {
				this.LeftFrame = value;
				this.RightFrame = value;
				this.TopFrame = value;
				this.BottomFrame = value;
			}
		}
		
		public char LeftTopCorner = '#';
		public char RightTopCorner = '#';
		public char LeftBottomCorner = '#';
		public char RightBottomCorner = '#';
		public char Corners
		{
			set {
				this.LeftTopCorner = value;
				this.RightTopCorner = value;
				this.LeftBottomCorner = value;
				this.RightBottomCorner = value;
			}
		}
		
		public override int Width {get; set;}
		public override int Height {get; set;}
		public override int X {get; set;}
		public override int Y {get; set;}
		
		public Frame()
		{
			this.X = 0;
			this.Y = 0;
			this.Width = 20;
			this.Height = 8;
		}
		
		public Frame(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}
		
		public Frame(int width, int height, int x, int y)
		{
			this.Width = width;
			this.Height = height;
			this.X = x;
			this.Y = y;
		}
		
		public Frame(int width, int height, int x, int y, char frames, char corners)
		{
			this.Width = width;
			this.Height = height;
			this.X = x;
			this.Y = y;
			this.Frames = frames;
			this.Corners = corners;
		}
		
		public override void Show()
		{	
			this.DisplayFrames();
			this.DisplayCorners();
		}
		
		protected void DisplayFrames()
		{
			Console.SetCursorPosition(X, Y);
			for(int i=0; i<Width; i++)
				Console.Write(TopFrame);
			
			Console.SetCursorPosition(X, Y+Height-1);
			for(int i=0; i<Width; i++)
				Console.Write(BottomFrame);
			
			for(int i=1; i<Height-1; i++)
			{
				Console.SetCursorPosition(X, Y+i);
				Console.Write(LeftFrame);
			}
			
			for(int i=1; i<Height-1; i++)
			{
				Console.SetCursorPosition(X+Width-1, Y+i);
				Console.Write(LeftFrame);
			}
		}
		
		protected void DisplayCorners()
		{
			Console.SetCursorPosition(X, Y);
			Console.Write(LeftTopCorner);
			
			Console.SetCursorPosition(X+Width-1, Y);
			Console.Write(RightTopCorner);
			
			Console.SetCursorPosition(X, Y+Height-1);
			Console.Write(LeftBottomCorner);
			
			Console.SetCursorPosition(X+Width-1, Y+Height-1);
			Console.Write(RightBottomCorner);
		}
	}
}
