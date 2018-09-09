/*
 * Created by SharpDevelop.
 * User: gladius882
 * Date: 2018-06-05
 * Time: 17:04
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Shelly
{
	/// <summary>
	/// Description of State.
	/// </summary>
	public abstract class State
	{	
		public abstract void Load();
		public abstract void Create();
		public abstract void Update();
		public abstract void Run();
	}
}
