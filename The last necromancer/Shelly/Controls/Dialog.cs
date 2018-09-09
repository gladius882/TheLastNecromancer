/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-07
 * Time: 18:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Shelly.Controls
{
	/// <summary>
	/// Description of Dialog.
	/// </summary>
	public class Dialog : ConsoleControl
	{
		private Frame Frame = new Frame();
		private Text Text = new Text();
		private AImage Image;
		 
		#region Properties
		public override int Width
		{
			get {
				return this.Frame.Width;
			}
			set {
				this.Frame.Width = value;
			}
		}
		
		public override int Height
		{
			get {
				return this.Frame.Height;
			}
			set {
				this.Frame.Height = value;
			}
		}
		
		public string Issue
		{
			get {
				return this.Text.Caption;
			}
			set {
				this.Text.Caption = value;
			}
		}
		
		public int TextPadding
		{
			get {
				return this.Text.Padding;
			}
			set {
				this.Text.Padding = value;
			}
		}
		
		public override int X
		{
			get {
				return this.Frame.X;
			}
			set {
				this.Frame.X = value;
			}
		}
		
		public override int Y
		{
			get {
				return this.Frame.Y;
			}
			set {
				this.Frame.Y = value;
			}
		}
		#endregion
		
		public Dialog(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}
		
		public void SetContent(AImage img, string text)
		{
			this.Image = img;
			this.Text.Caption = text;
			this.Text.Width = this.Width-2-img.Width;
			this.Text.Height = this.Height-2;
		}
		
		public override void Show()
		{
			this.Frame.Show();
			this.Image.Show(this.Frame.X+1, this.Frame.Y+1);
			this.Text.Show(this.Frame.X+1+this.Image.Width, this.Frame.Y+1);
		}
	}
}
