// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets a Float Variable to a random value between Min/Max.")]
	public class RandomIntSeed : FsmStateAction
	{
        
		[RequiredField]
		public FsmInt seed;
		[RequiredField]
		public FsmInt min;
		[RequiredField]
		public FsmInt max;
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmInt storeResult;

		public override void Reset()
		{
			min = 0;
			max = 1;
            
			storeResult = null;
		}

		public override void OnEnter()
		{
            
			Random.InitState(seed.Value);
            storeResult.Value = Random.Range(min.Value, max.Value);
			Finish();
		}
	}
}