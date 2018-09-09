/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-09
 * Time: 17:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Shelly;

namespace The_last_necromancer
{
	/// <summary>
	/// Description of IntroState.
	/// </summary>
	public class IntroState : State
	{
		public IntroState()
		{
			this.Load();
		}
		
		public override void Load()
		{
//			Console.WriteLine("Intro Load");
		}
		
		public override void Create()
		{
			Console.WriteLine("Intro Create");
		}
		
		public override void Update()
		{
			Console.WriteLine("Intro Update");
		}
		
		public override void Run()
		{
//			Console.WriteLine("Intro Run");
			Game.Instance.RunState("Menu");
		}
	}
}
