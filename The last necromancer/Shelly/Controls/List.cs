/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-09
 * Time: 15:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Shelly.Controls
{
	/// <summary>
	/// Description of List.
	/// </summary>
	public class List : ConsoleControl
	{
		private List<ListItem> Items = new List<ListItem>();
		
		public override int X {get; set;}
		public override int Y {get; set;}
		public override int Width {get; set;}
		public override int Height {get; set;}
		
		public List()
		{
		}
		
		public void Add(ListItem item)
		{
			this.Items.Add(item);
		}
		
		public void Clear()
		{
			this.Items.Clear();
		}
		
		public override void Show()
		{
			int line = 0;
			foreach(ListItem item in this.Items)
			{
				Console.SetCursorPosition(this.X, this.Y+line);
				Console.Write(item.Caption);
				line++;
			}
		}
	}
}
