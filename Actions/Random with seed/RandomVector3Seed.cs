// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets a Float Variable to a random value between Min/Max.")]
	public class RandomVector3Seed : FsmStateAction
	{
        
		[RequiredField]
		public FsmInt seed;
		[RequiredField]
		public FsmFloat min;
		[RequiredField]
		public FsmFloat max;
		[RequiredField]
		[UIHint(UIHint.Variable)]
		public FsmVector3 storeResult;

		public override void Reset()
		{
			min = 0f;
			max = 1f;
            
			storeResult = null;
		}

		public override void OnEnter()
		{
            
			Random.InitState(seed.Value);
            storeResult.Value = new Vector3(Random.Range(min.Value, max.Value), Random.Range(min.Value, max.Value), Random.Range(min.Value, max.Value));
			
			Finish();
		}
	}
}