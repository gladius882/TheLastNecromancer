/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-08
 * Time: 14:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Shelly.Controls
{
	/// <summary>
	/// Description of SinglelineMenuOption.
	/// </summary>
	public class SinglelineMenuOption : MenuOption
	{
		public string Caption;
		
		public override int X {get; set;}
		public override int Y {get; set;}
		
		public override int Width {get; set;}
		
		public override int Height
		{
			get {
				return 1;
			}
			set {
				
			}
		}
		
		public SinglelineMenuOption()
		{
		}
		
		public override void Show()
		{
			Console.Write(Caption);
		}
	}
}
