using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Hero_HeroWarmSimpleAI_node581 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			uint objID = (uint)pAgent.GetVariable(1128863647u);
			int range = (int)pAgent.GetVariable(2451377514u);
			bool flag = ((ObjAgent)pAgent).IsDistanceToActorLessThanRange(objID, range);
			bool flag2 = false;
			return (flag == flag2) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
