using System;

namespace behaviac
{
	internal class Parallel_bt_WrapperAI_Hero_HeroWarmNormalAI_node194 : Parallel
	{
		public Parallel_bt_WrapperAI_Hero_HeroWarmNormalAI_node194()
		{
			this.m_failPolicy = FAILURE_POLICY.FAIL_ON_ALL;
			this.m_succeedPolicy = SUCCESS_POLICY.SUCCEED_ON_ONE;
			this.m_exitPolicy = EXIT_POLICY.EXIT_ABORT_RUNNINGSIBLINGS;
			this.m_childFinishPolicy = CHILDFINISH_POLICY.CHILDFINISH_LOOP;
		}
	}
}
