/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-09
 * Time: 13:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Shelly.Controls
{
	/// <summary>
	/// Description of ConsoleControl.
	/// </summary>
	public abstract class ConsoleControl
	{
		public abstract int X {get; set;}
		public abstract int Y {get; set;}
		
		public abstract int Width {get; set;}
		public abstract int Height {get; set;}
		
		public abstract void Show();
	}
}
