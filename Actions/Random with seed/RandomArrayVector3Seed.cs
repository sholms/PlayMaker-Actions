// (c) Copyright HutongGames, LLC 2010-2013. All rights reserved.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Math)]
	[Tooltip("Sets a Float Variable to a random value between Min/Max.")]
	public class RandomArrayVector3Seed: FsmStateAction
	{    
        private FsmInt index;
        [RequiredField]
		public FsmInt maxindex;
		[RequiredField]
		public FsmFloat seed;
		[RequiredField]
		public FsmFloat min;
		[RequiredField]
		public FsmFloat max;
		[RequiredField]
		public FsmVector3 vector3Result;
        [RequiredField]
        [UIHint(UIHint.Variable)]
        [Tooltip("The Array Variable to use.")]
        public FsmArray arrayResult;

		public override void Reset()
		{
			min = 0f;
			max = 1f;
            seed = 0;
            maxindex = 0;
			arrayResult = null;
		}

		public override void OnEnter()
		{
            
	  Random.InitState((int)seed.Value);
      
        for (int i = 0; i < maxindex.Value; i++)
        { 
            arrayResult.Resize(arrayResult.Length + 1);
            vector3Result.Value = new Vector3(Random.Range(min.Value, max.Value), Random.Range(min.Value, max.Value), Random.Range(min.Value, max.Value));
            arrayResult.Set(arrayResult.Length - 1,vector3Result.Value);
			
			Finish();
		}
	}
}
}

