// (c) Copyright HutongGames, LLC 2010-2018. All rights reserved.

using System;
using UnityEngine;
using System.IO;

namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory("Collider")]
	public class BoxColliderModify : ComponentAction<BoxCollider>
	{
		[RequiredField]
		[CheckForComponent(typeof(BoxCollider))]
        public FsmOwnerDefault gameObject;
		//public FsmEvent Spawn;

		[System.NonSerialized]
		 BoxCollider tno;
		public FsmVector3 Position;
		public FsmVector3 Size;

		public FsmBool SetPosition;
		public FsmBool SetSize;

		public override void Reset()
		{

		}

		public override void OnEnter()
		{
            if (UpdateCache (Fsm.GetOwnerDefaultTarget (gameObject))) {
				tno = (BoxCollider)this.cachedComponent;
				Execute ();
			}

			Finish();
			

			

		}
        void Execute()
		{
			if (SetSize.Value == true){
				tno.size = Size.Value;
			}  
			if (SetPosition.Value == true){
				tno.center = Position.Value;
			}
			
		}

	}
}