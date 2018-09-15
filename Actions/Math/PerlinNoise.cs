// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using System;
using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Math")]
	public class PerlinNoise : FsmStateAction
	{
        public FsmFloat X;
		public FsmFloat Z;
        public FsmInt LoopMax;
		public FsmInt ActualLoop;
		public FsmFloat Refinement;
		public FsmFloat PerlinNoiseValue;
		public FsmEvent FinishEvent;
		public FsmEvent ActionEvent;

		public override void OnUpdate()
		{
            
				if (ActualLoop.Value == LoopMax.Value){
					Fsm.Event(FinishEvent);
				} else {
					PerlinNoiseValue.Value = Mathf.PerlinNoise(X.Value * Refinement.Value,Z.Value * Refinement.Value);
					Fsm.Event(ActionEvent);
				}

		}

	}
}