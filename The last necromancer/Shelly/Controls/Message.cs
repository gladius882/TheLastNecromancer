/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-02
 * Time: 15:42
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Shelly.Controls
{
	/// <summary>
	/// Display a text with a frame
	/// </summary>
	public class Message : ConsoleControl
	{
		private Text Text = new Text();
		private Frame Frame = new Frame();
		
		#region Frame properties
		public override int Width
		{
			get {
				return this.Frame.Width;
			}
			set {
				this.Frame.Width = value;
				this.Text.Width = value-2;
			}
		}
		
		public override int Height
		{
			get {
				return this.Frame.Height;
			}
			set {
				this.Frame.Height = value;
				this.Text.Height = value-2;
			}
		}
		public override int X
		{
			get {
				return this.Frame.X;
			}
			set {
				this.Frame.X = value;
				this.Text.X = value+1;
			}
		}
		
		public override int Y
		{
			get {
				return this.Frame.Y;
			}
			set {
				this.Frame.Y = value;
				this.Text.Y = value+1;
			}
		}
		
		public char LeftFrame
		{
			get {
				return this.Frame.LeftFrame;
			}
			set {
				this.Frame.LeftFrame = value;
			}
		}
		
		public char RightFrame
		{
			get {
				return this.Frame.RightFrame;
			}
			set {
				this.Frame.LeftFrame = value;
			}
		}
		
		public char TopFrame
		{
			get {
				return this.Frame.TopFrame;
			}
			set {
				this.Frame.TopFrame = value;
			}
		}
		
		public char BottomFrame
		{
			get {
				return this.Frame.BottomFrame;
			}
			set {
				this.Frame.BottomFrame = value;
			}
		}
		
		public char LeftTopCorner
		{
			get {
				return this.Frame.LeftTopCorner;
			}
			set {
				this.Frame.LeftTopCorner = value;
			}
		}
		
		public char RightTopCorner
		{
			get {
				return this.Frame.RightTopCorner;
			}
			set {
				this.Frame.RightTopCorner = value;
			}
		}
		
		public char LeftBottomCorner
		{
			get {
				return this.Frame.LeftBottomCorner;
			}
			set {
				this.Frame.LeftBottomCorner = value;
			}
		}
		
		public char RightBottomCorner
		{
			get {
				return this.Frame.RightBottomCorner;	
			}
			set {
				this.Frame.RightBottomCorner = value;
			}
		}
		
		#endregion
		
		#region Text properties
		public int Padding
		{
			get {
				return this.Text.Padding;
			}
			set {
				this.Text.Padding = value;
			}
		}
		
		public Aligment Aligment
		{
			get {
				return this.Text.Aligment;
			}
			set {
				this.Text.Aligment = value;
			}
		}
		
		public string Caption
		{
			get {
				return this.Text.Caption;
			}
			set {
				this.Text.Caption = value;
			}
		}
		#endregion
		
		public Message(string message)
		{
			this.Caption = message;
		}
		
		public override void Show()
		{
			this.Frame.Show();
			this.Text.Show();
		}
	}
}
