using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Monster_BTMonsterRunToInitiative_node89 : Action
	{
		private SkillSlotType method_p0;

		public Action_bt_WrapperAI_Monster_BTMonsterRunToInitiative_node89()
		{
			this.method_p0 = SkillSlotType.SLOT_SKILL_1;
		}

		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			return ((ObjAgent)pAgent).CanUseSkill(this.method_p0);
		}
	}
}
