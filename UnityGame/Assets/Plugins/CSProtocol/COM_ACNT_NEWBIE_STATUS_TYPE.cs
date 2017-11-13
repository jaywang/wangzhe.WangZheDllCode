using System;

namespace CSProtocol
{
	public enum COM_ACNT_NEWBIE_STATUS_TYPE
	{
		COM_ACNT_NEWBIE_STATUS_TYPE_NEWBIE_LEVEL,
		COM_ACNT_NEWBIE_STATUS_TYPE_PUT_ON_EQUIP,
		COM_ACNT_NEWBIE_STATUS_TYPE_HERO_ADVANCED,
		COM_ACNT_NEWBIE_STATUS_TYPE_USE_SOUL_STONE,
		COM_ACNT_NEWBIE_STATUS_TYPE_HERO_STAR,
		COM_ACNT_NEWBIE_STATUS_TYPE_HERO_SKILL_LVUP,
		COM_ACNT_NEWBIE_STATUS_TYPE_OPEN_CHEST,
		COM_ACNT_NEWBIE_STATUS_TYPE_THREE_HEROES,
		COM_ACNT_NEWBIE_STATUS_TYPE_PVP_TASK_REWARD,
		COM_ACNT_NEWBIE_STATUS_TYPE_BUY_HERO,
		COM_ACNT_NEWBIE_STATUS_TYPE_BUY_ITEM_IN_SHOP,
		COM_ACNT_NEWBIE_STATUS_TYPE_GET_CHAPTER_REWARD,
		COM_ACNT_NEWBIE_STATUS_TYPE_SWEEP,
		COM_ACNT_NEWBIE_STATUS_TYPE_COMBAT_GAME,
		COM_ACNT_NEWBIE_STATUS_TYPE_MASTER_ACTIVITY,
		COM_ACNT_NEWBIE_STATUS_TYPE_DREAM_ACTIVITY,
		COM_ACNT_NEWBIE_STATUS_TYPE_BURNING,
		COM_ACNT_NEWBIE_STATUS_TYPE_ELITE_ADVENTURE,
		COM_ACNT_NEWBIE_STATUS_TYPE_ENTER_GUILD,
		COM_ACNT_NEWBIE_STATUS_TYPE_USE_SYMBOL,
		COM_ACNT_NEWBIE_STATUS_TYPE_ENTER_SECRET_SHOP,
		COM_ACNT_NEWBIE_STATUS_TYPE_PVP_GUIDE,
		COM_ACNT_NEWBIT_STATUS_TYPE_COUPONS_FIRSTPAY,
		COM_ACNT_NEWBIT_STATUS_TYPE_COUPONS_FIRSTREWARD,
		COM_ACNT_NEWBIT_STATUS_TYPE_COUPONS_RENEWAL,
		COM_ACNT_NEWBIT_STATUS_TYPE_COUPONS_RENEWREWARD,
		COM_ACNT_NEWBIT_STATUS_PVPMATCH3V3_WITH_AI,
		COM_ACNT_NEWBIT_STATUS_PVPMATCH3V3_WITHOUT_AI,
		COM_ACNT_NEWBIT_STATUS_ENTER_PVPCOIN_SHOP,
		COM_ACNT_NEWBIT_STATUS_LEVELUP_GEAR,
		COM_ACNT_NEWBIT_STATUS_ADVANCE_GEAR,
		COM_ACNT_NEWBIT_STATUS_USE_EXP_ITEM,
		COM_ACNT_NEWBIT_STATUS_LEVELUP_HERO,
		COM_ACNT_NEWBIT_STATUS_ENTER_ARENA,
		COM_ACNT_NEWBIT_STATUS_PVE_TASK_REWARD,
		COM_ACNT_NEWBIT_STATUS_START_NEWBIE_LEVEL_1,
		COM_ACNT_NEWBIT_STATUS_START_NEWBIE_LEVEL_2,
		COM_ACNT_NEWBIE_STATUS_TYPE_MASTER_ACTIVITY_ENDOK = 39,
		COM_ACNT_NEWBIE_STATUS_TYPE_ARENA_ENDOK,
		COM_ACNT_NEWBIE_STATUS_TYPE_DREAM_ENDOK,
		COM_ACNT_NEWBIE_STATUS_TYPE_BURNING_ENDOK,
		COM_ACNT_NEWBIT_STATUS_QQVIP_REGISTERGIFT,
		COM_ACNT_NEWBIT_STATUS_COMBAT_3V3,
		COM_ACNT_NEWBIT_STATUS_COMBAT_3V3_START,
		COM_ACNT_NEWBIT_STATUS_SINGLE_3V3_ENTER,
		COM_ACNT_NEWBIT_STATUS_SINGLE_3V3_START,
		COM_ACNT_NEWBIT_STATUS_1_1_1_START,
		COM_ACNT_NEWBIT_STATUS_1_1_1_FIN,
		COM_ACNT_NEWBIT_STATUS_ARENA_SET,
		COM_ACNT_NEWBIT_STATUS_COMBAT_3V3_ENTER,
		COM_ACNT_NEWBIT_STATUS_1_1_1_START_33NOTFIN,
		COM_ACNT_NEWBIT_STATUS_1_1_1_FIN_33NOTFIN,
		COM_ACNT_NEWBIT_STATUS_SINGLE_33_ENTER_1_1_1_NOT,
		COM_ACNT_NEWBIT_STATUS_SINGLE_33_START_1_1_1_NOT,
		COM_ACNT_NEWBIT_STATUS_SINGLE_33_WIN_1_1_1_NOT,
		COM_ACNT_NEWBIT_STATUS_SINGLE_33_FAIL_1_1_1_NOT,
		COM_ACNT_NEWBIT_STATUS_MAKE_SYMBOL,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MATCHSUCC,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_AUTOCANCEL,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MATCHSUCC_END,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_AUTOCANCEL_START,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_AUTOCANCEL_END,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_11MATCH_ENTER,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_11MATCH_START,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_11MATCH_END,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_33MATCH_ENTER,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_33MATCH_START,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_33MATCH_END,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_33AI_ENTER,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_33AI_START,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_33AI_END,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_33AISINGLE_START,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_33AISINGLE_END,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_11AISINGLE_START,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_11AISINGLE_END,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_1_1_START,
		COM_ACNT_NEWBIT_STATUS_TEAM33AI_MANUELCANCEL_1_1_END,
		COM_ACNT_NEWBIT_STATUS_COIN_DRAW_FIVE,
		COM_ACNT_NEWBIT_STATUS_SINGLE_1V1_END,
		COM_ACNT_NEWBIE_STATUS_TYPE_TRAINING_GUIDE,
		COM_ACNT_NEWBIE_STATUS_TYPE_CORONA_GUIDE,
		COM_ACNT_NEWBIE_STATUS_TYPE_JUNGLE_GUIDE,
		COM_ACNT_NEWBIE_STATUS_TYPE_3V3_GUIDE,
		COM_ACNT_NEWBIE_STATUS_TYPE_FIRST_1V1_WARM_BATTLE_START,
		COM_ACNT_NEWBIE_STATUS_TYPE_FIRST_1V1_WARM_BATTLE_END,
		COM_ACNT_NEWBIE_STATUS_TYPE_FIRST_5V5_WARM_BATTLE_START,
		COM_ACNT_NEWBIE_STATUS_TYPE_FIRST_5V5_WARM_BATTLE_WIN,
		COM_ACNT_NEWBIE_STATUS_TYPE_FIRST_5V5_WARM_BATTLE_LOSE,
		COM_ACNT_NEWBIE_STATUS_TYPE_CORONA_GUIDE_START,
		COM_ACNT_NEWBIE_STATUS_TYPE_SECOND_5V5_WARM_BATTLE_START,
		COM_ACNT_NEWBIE_STATUS_TYPE_SECOND_5V5_WARM_BATTLE_WIN,
		COM_ACNT_NEWBIE_STATUS_TYPE_SECOND_5V5_WARM_BATTLE_LOSE,
		COM_ACNT_NEWBIE_STATUS_TYPE_REAL_5V5_START,
		COM_ACNT_NEWBIE_STATUS_TYPE_REAL_5V5_WIN,
		COM_ACNT_NEWBIE_STATUS_TYPE_REAL_5V5_LOSE,
		COM_ACNT_NEWBIE_STATUS_TYPE_5V5_GUIDE,
		COM_ACNT_NEWBIE_STATUS_TYPE_GAMEVIP_GIFT,
		COM_ACNT_NEWBIT_STATUS_DIAMOND_DRAW,
		COM_ACNT_NEWBIT_STATUS_FIRST_ENTERTAINMENT_START,
		COM_ACNT_NEWBIT_STATUS_FIRST_ENTERTAINMENT_END,
		COM_ACNT_NEWBIT_STATUS_FIRST_MATCH_PKAI_START,
		COM_ACNT_NEWBIT_STATUS_FIRST_MATCH_PKAI_END,
		COM_ACNT_NEWBIT_STATUS_OLDPLAYER,
		COM_ACNT_NEWBIE_STATUS_TYPE_MAX
	}
}
