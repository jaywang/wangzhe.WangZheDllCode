using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Condition_bt_WrapperAI_Monster_BTMonsterPassive_node25 : Condition
	{
		private SkillSlotType opl_p0;

		public Condition_bt_WrapperAI_Monster_BTMonsterPassive_node25()
		{
			this.opl_p0 = SkillSlotType.SLOT_SKILL_2;
		}

		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			bool flag = ((ObjAgent)pAgent).IsSkillCDReady(this.opl_p0);
			bool flag2 = true;
			return (flag == flag2) ? EBTStatus.BT_SUCCESS : EBTStatus.BT_FAILURE;
		}
	}
}
