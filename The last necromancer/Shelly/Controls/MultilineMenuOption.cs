/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-08
 * Time: 14:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Shelly.Controls
{
	/// <summary>
	/// Description of MultilineMenuOption.
	/// </summary>
	public class MultilineMenuOption : MenuOption
	{
		private List<string> Lines = new List<string>();
		
		public override int X {get; set;}
		public override int Y {get; set;}
		
		public override int Height
		{
			get {
				return this.Lines.Count;
			}
			set {
				
			}	
		}
		
		public override int Width {get; set;}
		
		public MultilineMenuOption()
		{
		}
		
		public void SetMultilineCaption(string[] lines)
		{
			this.Lines.Clear();
			foreach(string line in lines)
			{
				this.Lines.Add(line);
			}
		}
		
		public override void Show()
		{
			int x = Console.CursorLeft;
			int y = Console.CursorTop;
			
			int pos = 0;
			foreach(string line in this.Lines)
			{	
				Console.SetCursorPosition(x, y+pos);
				Console.Write(line);
				pos++;
			}
		}
	}
}
