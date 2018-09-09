/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-09
 * Time: 17:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Shelly;
using Shelly.Controls;

namespace The_last_necromancer
{
	/// <summary>
	/// Description of MenuState.
	/// </summary>
	public class MenuState : State
	{
		private Menu Menu = new Menu();
		
		public MenuState()
		{
			this.Load();
		}
		
		public override void Create()
		{
			;
		}
		
		public override void Load()
		{
			MultilineMenuOption op1 = new MultilineMenuOption();
			op1.SetMultilineCaption(new string[] {@" ____                                     _  _",
			                        			  @"|  _ \ ___ _____ __   ___   ___ _____ __ (_)(_)   __ _ _ __ ___ ",
			                        			  @"| |_) / _ \_  / '_ \ / _ \ / __|_  / '_ \| || |  / _` | '__/ _ \",
			                        			  @"|  _ < (_) / /| |_) | (_) | (__ / /| | | | || | | (_| | | |  __/",
			                        		      @"|_| \_\___/___| .__/ \___/ \___/___|_| |_|_|/ |  \__, |_|  \___|",
			                        			  @"              |_|                         |__/   |___/       (_(",});
			
			MultilineMenuOption op2 = new MultilineMenuOption();
			op2.SetMultilineCaption(new string[] {@"    _         _",
			                        			  @"   / \  _   _| |_ ___  _ __ _____   _ ",
			                        			  @"  / _ \| | | | __/ _ \| '__|_  / | | |",
			                        			  @" / ___ \ |_| | || (_) | |   / /| |_| |",
			                        			  @"/_/   \_\__,_|\__\___/|_|  /___|\__, |",
			                        			  @"                                |___/"});
			
			MultilineMenuOption op3 = new MultilineMenuOption();
			op3.SetMultilineCaption(new string[] {@" _   _     _                 _            _",
			                        			  @"| | | |___| |_ __ ___      _(_) ___ _ __ (_) __ _ ",
			                        			  @"| | | / __| __/ _` \ \ /\ / / |/ _ \ '_ \| |/ _` |",
			                        			  @"| |_| \__ \ || (_| |\ V  V /| |  __/ | | | | (_| |",
			                        			  @" \___/|___/\__\__,_| \_/\_/ |_|\___|_| |_|_|\__,_|"});
			
			MultilineMenuOption op4 = new MultilineMenuOption();
			op4.SetMultilineCaption(new string[] {@" __        __      _   __     _ ",
			                        			  @" \ \      / /   _ (_)_/_/ ___(_) ___",
			                        			  @"  \ \ /\ / / | | || / __|/ __| |/ _ \",
			                        			  @"   \ V  V /| |_| || \__ \ (__| |  __/",
			                        			  @"    \_/\_/  \__, |/ |___/\___|_|\___|",
			                        			  @"            |___/__/"});
			
			Menu = new Menu();
			Menu.X = 30;
			Menu.Y = 4;
			Menu.ActiveColor = ConsoleColor.Magenta;
			Menu.AddOption(op1);
			Menu.AddOption(op2);
			Menu.AddOption(op3);
			Menu.AddOption(op4);
		}
		
		public override void Update()
		{
			Console.WriteLine("Menu Update");
		}
		
		public override void Run()
		{
			int selected = Menu.Show();
			
			if(selected == 0)
			{
				;
			}
			else if(selected == 1)
			{
				;
			}
			else if(selected == 2)
			{
				;
			}
			if(selected == 3)
				Game.Instance.Terminate(0);
		}
	}
}
