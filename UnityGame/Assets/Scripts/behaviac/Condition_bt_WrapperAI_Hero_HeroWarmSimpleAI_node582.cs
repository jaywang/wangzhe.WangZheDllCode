using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Hero_HeroWarmSimpleAI_node582 : Condition
	{
		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			int num = (int)pAgent.GetVariable(3103756267u);
			int num2 = 25;
			return (num > num2) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
