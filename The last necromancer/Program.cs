/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-01
 * Time: 21:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Shelly;
using Shelly.Controls;

namespace The_last_necromancer
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.SetWindowSize(120, 38);
			Console.BufferWidth = 120;
			Console.BufferHeight = 38;
			Console.CursorVisible = false;
			Console.Title = "The last necromancer";
			
			AImage img = new AImage();
			img.LoadFromFile("img/img.aimg");
//			img.Show(10, 0);
			
			Message msg = new Message("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ante massa, viverra ac ante at, ullamcorper malesuada nunc. Vestibulum in ex");
			msg.X = 80;
			msg.Y = 0;
			msg.Width = 40;
			msg.Height = 8;
			msg.Padding = 0;
			msg.Aligment = Aligment.Left;
//			msg.Show();
			
			Frame frame = new Frame(80, 20, 20, 9, '-', '+');
//			frame.Show();
			
			Text text = new Text();
			text.Width = 16;
			text.Aligment = Aligment.Center;
			text.Caption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ante massa, viverra ac ante at, ullamcorper malesuada nunc. Vestibulum in ex";
//			text.Show();
			
			
			AImage portrait = new AImage();
			portrait.LoadFromFile("img/hero.aimg");
			Dialog dialog = new Dialog(40, 8);
			dialog.SetContent(portrait, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ante massa, viverra ac ante at, ullamcorper");
			dialog.TextPadding = 1;
			dialog.X = 10;
			dialog.Y = 5;
//			dialog.Show();
			

			List list = new List();
			list.X = 10;
			list.Y = 20;
			list.Add(new ListItem("Element 1", "val1"));
			list.Add(new ListItem("Element 2", "val2"));
			list.Add(new ListItem("Element 3", "val3"));
			list.Add(new ListItem("Element 4", "val4"));
			list.Add(new ListItem("Element 5", "val5"));
//			list.Show();
			
			
			Game game = Game.Instance;
			game.AddState(new IntroState(), "Intro");
			game.AddState(new MenuState(), "Menu");
			
			game.RunState("Intro");
		}
	}
}