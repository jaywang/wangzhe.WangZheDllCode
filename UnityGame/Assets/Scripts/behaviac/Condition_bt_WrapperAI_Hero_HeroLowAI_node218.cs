using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Hero_HeroLowAI_node218 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((ObjAgent)pAgent).IsControlByMan();
			bool flag2 = true;
			return (flag == flag2) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
