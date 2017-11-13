using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Hero_HeroCommonAutoAI_node387 : Condition
	{
		private int opl_p1;

		public Condition_bt_WrapperAI_Hero_HeroCommonAutoAI_node387()
		{
			this.opl_p1 = 2500;
		}

		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			uint objID = (uint)pAgent.GetVariable(2120643215u);
			bool flag = ((ObjAgent)pAgent).IsDistanceToActorLessThanRange(objID, this.opl_p1);
			bool flag2 = true;
			return (flag == flag2) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
