/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-09
 * Time: 17:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using Shelly.Controls;

namespace Shelly
{
	/// <summary>
	/// Description of Game.
	/// </summary>
	public sealed class Game
	{
		private static Game instance = new Game();
		private Dictionary<string, State> States = new Dictionary<string, State>();
		
		public static Game Instance {
			get {
				return instance;
			}
		}
		
		public void AddState(State state, string name)
		{
			Game.Instance.States.Add(name, state);
		}
		
		public int GetStatesCount()
		{
			return Game.Instance.States.Count;
		}
		
		public void RunState(string name)
		{
			Game.Instance.States[name].Run();
		}
		
		public void Terminate(int exitCode = 0)
		{
			Environment.Exit(exitCode);
		}
		
		private Game()
		{
		}
	}
}
