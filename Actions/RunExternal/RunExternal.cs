// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

 using UnityEngine;
 using System.Collections;
 using System.Diagnostics;
 using System;
namespace HutongGames.PlayMaker.Actions

{


using HutongGames.PlayMaker.Actions;

	[ActionCategory("External Aplication")]
	public class RunExternal : FsmStateAction
	{

		

		public override void Reset()
		{
			
			
            
		}

		public override void OnEnter()
		{
		  System.Diagnostics.Process.Start(Application.dataPath + "/Run.bat");

		}

	}
	}
