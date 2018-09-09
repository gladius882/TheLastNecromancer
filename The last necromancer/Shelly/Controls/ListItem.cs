/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-09
 * Time: 16:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Shelly.Controls
{
	/// <summary>
	/// Description of ListItem.
	/// </summary>
	public class ListItem
	{
		public string Caption;
		public string Value;
		
		public ListItem(string caption, string value)
		{
			this.Caption = caption;
			this.Value = value;
		}
	}
}
