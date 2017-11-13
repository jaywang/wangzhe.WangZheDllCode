using System;

namespace ResData
{
	public enum RES_GLOBAL_CONF_TYPE
	{
		RES_GLOBAL_CONF_TYPE_NULL,
		RES_GLOBAL_CONF_TYPE_APINTERVAL,
		RES_GLOBAL_CONF_TYPE_APINCVALUE,
		RES_GLOBAL_CONF_TYPE_MAXAP,
		RES_GLOBAL_CONF_TYPE_INITAP,
		RES_GLOBAL_CONF_TYPE_INITCOIN,
		RES_GLOBAL_CONF_TYPE_INITCOUPONS,
		RES_GLOBAL_CONF_TYPE_INITHERO1,
		RES_GLOBAL_CONF_TYPE_INITHERO2,
		RES_GLOBAL_CONF_TYPE_INITHERO3,
		RES_GLOBAL_CONF_TYPE_REFRESHDAY,
		RES_GLOBAL_CONF_TYPE_HP_LIMIT,
		RES_GLOBAL_CONF_TYPE_ATTACK_LIMIT,
		RES_GLOBAL_CONF_TYPE_SPELL_LIMIT,
		RES_GLOBAL_CONF_TYPE_DEFENSE_LIMIT,
		RES_GLOBAL_CONF_TYPE_RESIST_LIMIT,
		RES_GLOBAL_CONF_TYPE_MAX_DONATEAP_PERDAY,
		RES_GLOBAL_CONF_TYPE_MAX_RECVAP_PERDAY,
		RES_GLOBAL_CONF_TYPE_COINDRAW_FREELIMIT,
		RES_GLOBAL_CONF_TYPE_COINDRAW_CD,
		RES_GLOBAL_CONF_TYPE_DRAWHERO_FREE,
		RES_GLOBAL_CONF_TYPE_DRAWHERO_CD,
		RES_GLOBAL_CONF_TYPE_COINBUY_LIMIT,
		RES_GLOBAL_CONF_TYPE_APBUY_LIMIT,
		RES_GLOBAL_CONF_TYPE_SKILLPOINTREFRESH,
		RES_GLOBAL_CONF_TYPE_SKILLPOINTLIMIT = 26,
		RES_GLOBAL_CONF_TYPE_SPBUY_LIMIT,
		RES_GLOBAL_CONF_TYPE_COINBUY_LVLINC,
		RES_GLOBAL_CONF_TYPE_BALANCE_LOWLIMIT_LVL = 31,
		RES_GLOBAL_CONF_TYPE_BALANCE_TRANSFORM_LVL,
		RES_GLOBAL_CONF_TYPE_MOPUP_TICKET_ID,
		RES_GLOBAL_CONF_TYPE_MOPUP_TICKET_NUM,
		RES_GLOBAL_CONF_TYPE_FREC_LVL_GAP = 39,
		RES_GLOBAL_CONF_TYPE_PURE_BALANCE_LVL = 41,
		RES_GLOBAL_CONF_TYPE_LVLCHALLENGE_LIMIT,
		RES_GLOBAL_CONF_TYPE_BURNING_RESET_MAX_NUM,
		RES_GLOBAL_CONF_TYPE_PVP_LEVEL_LIMIT,
		RES_GLOBAL_CONF_TYPE_BURNING_HERO_LV_LIMIT,
		RES_GLOBAL_CONF_TYPE_TRANK_MAX_RANK_NO,
		RES_GLOBAL_CONF_TYPE_GET_TRANK_LIST_INTERVAL,
		RES_GLOBAL_CONF_TYPE_ARENA_FIGHT_LIMIT,
		RES_GLOBAL_CONF_TYPE_ARENA_FIGHT_CDTIME,
		RES_GLOBAL_CONF_TYPE_ARENA_SETTLE_BEGINTIME,
		RES_GLOBAL_CONF_TYPE_ARENA_SETTLE_ENDTIME,
		RES_GLOBAL_CONF_TYPE_DRAWSKIN_FREE,
		RES_GLOBAL_CONF_TYPE_DRAWSKIN_CD,
		RES_GLOBAL_CONF_TYPE_ENTER_PVP_GUIDE,
		RES_GLOBAL_CONF_TYPE_PVP_GUIDE_LEVEL_ID,
		RES_GLOBAL_CONF_TYPE_HORIZON_RADIUS,
		RES_GLOBAL_CONF_TYPE_OPENBOXBYCOUPONS_LOOPCNT,
		RES_GLOBAL_CONF_TYPE_HEROPOOLEXP_LIMIT,
		RES_GLOBAL_CONF_TYPE_DAILY_PVP_COIN_LIMIT,
		RES_GLOBAL_CONF_TYPE_COUPONS_FIRSTPAY,
		RES_GLOBAL_CONF_TYPE_COUPONS_RENEWVAL,
		RES_GLOBAL_CONF_TYPE_COUPONS_FIRSTPAY_LIMIT,
		RES_GLOBAL_CONF_TYPE_COUPONS_RENEWVAL_LIMIT,
		RES_GLOBAL_CONF_TYPE_EXP_JUANZHOU_ID,
		RES_GLOBAL_CONF_TYPE_EXP_BINGFA_ID,
		RES_GLOBAL_CONF_TYPE_EXP_MIZHUAN_ID,
		RES_GLOBAL_CONF_TYPE_EXP_BAODIAN_ID,
		RES_GLOBAL_CONF_TYPE_EXP_QUANSHU_ID,
		RES_GLOBAL_CONF_INIT_COMBAT_ABILITY,
		RES_GLOBAL_CONF_BUY_HERO_ID,
		RES_GLOBAL_CONF_GET_PVP_TASK_REWARD_TASKID,
		RES_GLOBAL_CONF_TYPE_HURT_UP_RATE,
		RES_GLOBAL_CONF_TYPE_HURT_UP_RATE_LIMIT,
		RES_GLOBAL_CONF_TYPE_HURTED_DOWN_RATE,
		RES_GLOBAL_CONF_TYPE_HURTED_DOWN_RATE_LIMIT,
		RES_GLOBAL_CONF_TYPE_HURT_DOWN_RATE,
		RES_GLOBAL_CONF_TYPE_HURT_DOWN_RATE_LIMIT,
		RES_GLOBAL_CONF_TYPE_HURTED_UP_RATE,
		RES_GLOBAL_CONF_TYPE_HURTED_UP_RATE_LIMIT,
		RES_GLOBAL_CONF_GET_PVE_TASK_REWARD_TASKID,
		RES_GLOBAL_CONF_TYPE_QQVIP_LOGINGIFT,
		RES_GLOBAL_CONF_TYPE_QQSUPERVIP_LOGINGIFT,
		RES_GLOBAL_CONF_TYPE_QQVIP_GOLDADDRATIO,
		RES_GLOBAL_CONF_TYPE_QQSUPERVIP_GOLDADDRATIO,
		RES_GLOBAL_CONF_TYPE_COUPONSCOSTCHKPCT,
		RES_GLOBAL_CONF_DIRECT_BUY_ITEM_CNT,
		RES_GLOBAL_CONF_MAX_OPEN_ADVENTURE_DIFFICULT,
		RES_GLOBAL_CONF_TYPE_QQVIP_REGISTERGIFT,
		RES_GLOBAL_CONF_TYPE_QQSUPERVIP_REGISTERGIFT,
		RES_GLOBAL_CONF_TYPE_PVPCOIN_DAILYLIMIT,
		RES_GLOBAL_CONF_TYPE_PVPEXP_DAILYLIMIT,
		RES_GLOBAL_CONF_TYPE_MAX_REFRESH_USUALTASKCNT,
		RES_GLOBAL_CONF_TYPE_MAX_PVETIPS_COUNT,
		RES_GLOBAL_CONF_TYPE_MAX_PVPTIPS_COUNT,
		RES_GLOBAL_CONF_TYPE_BATTLECHAT_CD = 98,
		RES_GLOBAL_CONF_TYPE_CONTIWIN_REFRESHTIME,
		RES_GLOBAL_CONF_TYPE_RANK_FUNCOPEN_NEEDLV,
		RES_GLOBAL_CONF_TYPE_RANK_FUNCOPEN_NEEDHERONUM,
		RES_GLOBAL_CONF_TYPE_GUIDELEVEL2_FADE_GIFT_HERO,
		RES_GLOBAL_CONF_TYPE_LUCKYDRAW_REFRESH_WDAY,
		RES_GLOBAL_CONF_TYPE_LUCKYDRAW_REFRESH_TIME,
		RES_GLOBAL_CONF_TYPE_AUTO_SINGLE_MATCH_TIMER,
		RES_GLOBAL_CONF_TYPE_AUTO_SINGLE_MATCH_LEVEL_LIMIT,
		RES_GLOBAL_CONF_TYPE_REWARD_LIMIT_REFRESH_TIME,
		RES_GLOBAL_CONF_TYPE_DONATE_FRIEND_COIN_NUM,
		RES_GLOBAL_CONF_TYPE_HERO_HEAD_POINTS,
		RES_GLOBAL_CONF_TYPE_DISCONNDTIME_TO_ASSIST,
		RES_GLOBAL_CONF_TYPE_HANGUPTIME_TO_ASSIST,
		RES_GLOBAL_CONF_TYPE_HANGUPTIME_TO_AI,
		RES_GLOBAL_CONF_TYPE_HANGUPTIME_TO_WARN,
		RES_GLOBAL_CONF_TYPE_1V1_GUIDE_HERO,
		RES_GLOBAL_CONF_TYPE_JUNGLE_GUIDE_HERO,
		RES_GLOBAL_CONF_TYPE_1V1_GUIDE_LEVEL,
		RES_GLOBAL_CONF_TYPE_3V3_GUIDE_LEVEL,
		RES_GLOBAL_CONF_TYPE_5V5_GUIDE_LEVEL,
		RES_GLOBAL_CONF_TYPE_CASTING_GUIDE_LEVEL,
		RES_GLOBAL_CONF_TYPE_TRAIN_LEVEL,
		RES_GLOBAL_CONF_TYPE_JUNGLE_LEVEL,
		RES_GLOBAL_CONF_TYPE_DRAWSYMBOL_COMMON_CD,
		RES_GLOBAL_CONF_TYPE_DRAWSYMBOL_SENIOR_CD,
		RES_GLOBAL_CONF_TYPE_CHAT_FREE_CNT,
		RES_GLOBAL_CONF_TYPE_CHAT_PRICE_ONCE,
		RES_GLOBAL_CONF_TYPE_CHAT_PRICE_TYPE,
		RES_GLOBAL_CONF_TYPE_CHAT_DOOR_LEVEL,
		RES_GLOBAL_CONF_TYPE_USERNAME_DOOR_LEVEL,
		RES_GLOBAL_CONF_TYPE_HANGUP_PUNISH_LIGHT,
		RES_GLOBAL_CONF_TYPE_HANGUP_PUNISH_SERIOUS,
		RES_GLOBAL_CONF_TYPE_EXPHERO_MAXDAYS,
		RES_GLOBAL_CONF_TYPE_EXPSKIN_MAXDAYS,
		RES_GLOBAL_CONF_TYPE_INACTIVE_KAVALUE,
		RES_GLOBAL_CONF_TYPE_HERO_EXCHANGE_ID,
		RES_GLOBAL_CONF_TYPE_HEROSKIN_EXCHANGE_ID,
		RES_GLOBAL_CONF_TYPE_SHARE_TLOG_SPLIT_TIME,
		RES_GLOBAL_CONF_TYPE_SURRENDER_START_TIME,
		RES_GLOBAL_CONF_TYPE_SURRENDER_VALID_TIME,
		RES_GLOBAL_CONF_TYPE_SURRENDER_CD_TIME,
		RES_GLOBAL_CONF_TYPE_WXGAMECENTER_LOGINGIFT,
		RES_GLOBAL_CONF_TYPE_WXGAMECENTER_LOGIN_GOLDADDRATIO,
		RES_GLOBAL_CONF_TYPE_PVE_SKILL1LVLMAX,
		RES_GLOBAL_CONF_TYPE_PVE_SKILL3LVLMAX,
		RES_GLOBAL_CONF_TYPE_3V3_GUIDE_HERO,
		RES_GLOBAL_CONF_TYPE_5V5_GUIDE_HERO,
		RES_GLOBAL_CONF_TYPE_CASTING_GUIDE_HERO,
		RES_GLOBAL_CONF_TYPE_WARM_1V1_SPECIAL_MAP_ID,
		RES_GLOBAL_CONF_TYPE_WARM_5V5_SPECIAL_MAP_ID,
		RES_GLOBAL_CONF_TYPE_WAIT_CONFIRM_TIME,
		RES_GLOBAL_CONF_TYPE_FIRSTWIN_CD,
		RES_GLOBAL_CONF_TYPE_FIRSTWIN_PVPEXP,
		RES_GLOBAL_CONF_TYPE_FIRSTWIN_PVPCOIN,
		RES_GLOBAL_CONF_TYPE_FIRSTWIN_PVPLVL,
		RES_GLOBAL_CONF_TYPE_INIT_UNLOCK_SKILLID,
		RES_GLOBAL_CONF_TYPE_ACTIVATE_ADV_VIDEO_LINK,
		RES_GLOBAL_CONF_TYPE_INVITE_FRIEND_CD,
		RES_GLOBAL_CONF_TYPE_RAND_SEL_HERO_GOLD,
		RES_GLOBAL_CONF_TYPE_RECALL_FRIEND,
		RES_GLOBAL_CONF_TYPE_VICTORYSHARE_PVPLVL,
		RES_GLOBAL_CONF_TYPE_CHAT_REPEAT_CNT,
		RES_GLOBAL_CONF_TYPE_MONTH_CARD_RENEW_DAY_CNT,
		RES_GLOBAL_CONF_TYPE_GAIN_CHEST,
		RES_GLOBAL_CONF_TYPE_MONTH_CARD_TASKID,
		RES_GLOBAL_CONF_TYPE_WEEK_CARD_TASKID,
		RES_GLOBAL_CONF_TYPE_RECALL_ITEM_ID,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_HERO_WIN_RATE_TTH,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_HERO_NUM,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_WIN_RATE_TTH,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_GAME_NUM,
		RES_GLOBAL_CONF_TYPE_HEADIMG_INITID,
		RES_GLOBAL_CONF_REWARD_MTCH_PLAYER_NUM_SHOW_LIMIT,
		RES_GLOBAL_CONF_TEHUIGIFT_1,
		RES_GLOBAL_CONF_TEHUIGIFT_2,
		RES_GLOBAL_CONF_TYPE_NEWBIEGIFT_SHOWSEC,
		RES_GLOBAL_CONF_TYPE_DISCONNDTIME_TO_HANGUP,
		RES_GLOBAL_CONF_TYPE_AFKTIME_TO_HANGUP,
		RES_GLOBAL_CONF_TYPE_LOSE_MVP_SCORE_LIMIT,
		RES_GLOBAL_CONF_TYPE_PLAYER_INFO_COMMON_HERO_NUM,
		RES_GLOBAL_CONF_TYPE_SPECGIFT_SALELIMIT,
		RES_GLOBAL_CONF_TYPE_QQGAMECENTER_LOGINGIFT,
		RES_GLOBAL_CONF_TYPE_QQGAMECENTER_LOGIN_GOLDADDRATIO,
		RES_GLOBAL_CONF_TYPE_FORCE_KILL_CRYSTAL_INTERVAL,
		RES_GLOBAL_CONF_TYPE_WAITTIME_MAX,
		RES_GLOBAL_CONF_TYPE_MAX_GRADE_RANK_PUNISH_INTERVAL,
		RES_GLOBAL_CONF_TYPE_HONOR_KILL_FACTOR,
		RES_GLOBAL_CONF_TYPE_HONOR_ASSIST_FACTOR,
		RES_GLOBAL_CONF_TYPE_HONOR_DEAD_FACTOR,
		RES_GLOBAL_CONF_TYPE_KDA_KILL_MOST_LIMIT,
		RES_GLOBAL_CONF_TYPE_KDA_ASSIST_MOST_LIMIT,
		RES_GLOBAL_CONF_TYPE_KDA_ORGAN_KILL_MOST_LIMIT,
		RES_GLOBAL_CONF_TYPE_SHARE_ROOM_LEVEL,
		RES_GLOBAL_CONF_TYPE_HERO_PRESENT_LIMIT,
		RES_GLOBAL_CONF_TYPE_BATTLECHAT_INPUT_CD,
		RES_GLOBAL_CONF_TYPE_BATTLECHAT_INPUT_SWITCH,
		RES_GLOBAL_CONF_TYPE_INTIMACY_LIMITVALUE,
		RES_GLOBAL_CONF_TYPE_IOSVISITOR_LOGINGIFT,
		RES_GLOBAL_CONF_TYPE_IOSVISITOR_LOGIN_GOLDADDRATIO,
		RES_GLOBAL_CONF_TYPE_GREATMATCH_GRADERANK,
		RES_GLOBAL_CONF_TYPE_INTIMACY_DAYLIMITVALUE,
		RES_GLOBAL_CONF_TYPE_REWARDMATCH_DAILY_COUNT,
		RES_GLOBAL_CONF_TYPE_NAMECHANGECARD_SHOPID,
		RES_GLOBAL_CONF_TYPE_GUILDNAMECHANGECARD_SHOPID,
		RES_GLOBAL_CONF_TYPE_FRIENDPRESENT_SECOND,
		RES_GLOBAL_CONF_TYPE_LOBBY_PLAT_CHANNEL_SHOW_RULE,
		RES_GLOBAL_CONF_TYPE_LADDER_HIGHEST_GRADE_RANK_CLASS_LIMIT,
		RES_GLOBAL_CONF_TYPE_GREATMATCH_GRADE,
		RES_GLOBAL_CONF_TYPE_SELFDEFINE_CHATINFOPOS_NUM,
		RES_GLOBAL_CONF_TYPE_PLATFORM_DAY_REFRESH_TIME,
		RES_GLOBAL_CONF_TYPE_UNIONBBATTLE_EXCHG_ACTIVITY_ID,
		RES_GLOBAL_CONF_TYPE_SHOW_WINTRICKTIPS_PVPLOSE_TIMES,
		RES_GLOBAL_CONF_TYPE_LOUDSPEAKER_SHOPID,
		RES_GLOBAL_CONF_TYPE_SPEAKER_SHOPID,
		RES_GLOBAL_CONF_TYPE_HANGUP_PUNISH_TYPE,
		RES_GLOBAL_CONF_TYPE_SUPER_MASTER_TEXT,
		RES_GLOBAL_CONF_TYPE_OBSERVE_DELAY,
		RES_GLOBAL_CONF_TYPE_INVITE_LBS_REFRESH_TIME,
		RES_GLOBAL_CONF_TYPE_NORMAL_RANK_MAPID,
		RES_GLOBAL_CONF_TYPE_BANPICK_RANK_MAPID,
		RES_GLOBAL_CONF_TYPE_RECORDER_KINGTIME_EVENTSTARTTIMEINTERVAL,
		RES_GLOBAL_CONF_TYPE_RECORDER_KINGTIME_EVENTNUMMAX,
		RES_GLOBAL_CONF_TYPE_RECORDER_KINGTIME_VIDEO543KILLTOTALTIME,
		RES_GLOBAL_CONF_TYPE_FOW_EXPOSE_RADIUS,
		RES_GLOBAL_CONF_TYPE_FOW_EXPOSE_DURATION_NORMAL,
		RES_GLOBAL_CONF_TYPE_FOW_EXPOSE_DURATION_HERO,
		RES_GLOBAL_CONF_TYPE_MASTER_HERO_PROFICIENCY,
		RES_GLOBAL_CONF_TYPE_MASTER_HERO_RANK_WIN,
		RES_GLOBAL_CONF_TYPE_MASTER_HERO_RANK_SCORE,
		RES_GLOBAL_CONF_TYPE_MASTER_HERO_NORMAL_5V5,
		RES_GLOBAL_CONF_TYPE_MASTER_HERO_SCORE_RATE,
		RES_GLOBAL_CONF_TYPE_MASTER_HERO_RESET_TIME,
		RES_GLOBAL_CONF_TYPE_RECORDER_KINGTIME_ANDROIDMINSPACELIMIT,
		RES_GLOBAL_CONF_TYPE_RECORDER_KINGTIME_IOSMINSPACELIMIT,
		RES_GLOBAL_CONF_TYPE_LADDER_WARM_BATTLE_SURRENDER_TIME_FREQ,
		RES_GLOBAL_CONF_TYPE_LADDER_WARM_BATTLE_SURRENDER_RANDOM_TTH,
		RES_GLOBAL_CONF_TYPE_LADDER_WARM_BATTLE_SURRENDER_KILL_DIFF,
		RES_GLOBAL_CONF_TYPE_SHOW_BUYTONGCAI_BTN,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_WIN_RATE_NUM = 239,
		RES_GLOBAL_CONF_TYPE_OBTIP_INTERVAL,
		RES_GLOBAL_CONF_TYPE_HIGHEST_LEVEL,
		RES_GLOBAL_CONF_TYPE_CANCELPAUSE_WAITTIME,
		RES_GLOBAL_CONF_TYPE_CANCELPAUSE_COUNTDOWN,
		RES_GLOBAL_CONF_TYPE_CURMEMNOTENOUGH_TIPS,
		RES_GLOBAL_CONF_TYPE_ENEMYATKBTN_ENEMYDISTANCEMAX,
		RES_GLOBAL_CONF_TYPE_FAKE_SIGHT_RADIUS,
		RES_GLOBAL_CONF_TYPE_ADDFRIEND_PERHOUR,
		RES_GLOBAL_CONF_TYPE_RECORDER_KINGTIME_ONCEDOUBLEEVENTTIMEINTERVAL,
		RES_GLOBAL_CONF_TYPE_RECORDER_KINGTIME_EVENTENDTIMEINTERVAL,
		RES_GLOBAL_CONF_TYPE_MVP_RATE_HEROHURT,
		RES_GLOBAL_CONF_TYPE_MVP_RATE_COIN,
		RES_GLOBAL_CONF_TYPE_MVP_RATE_GODLIKE,
		RES_GLOBAL_CONF_TYPE_MVP_RATE_TRIPLEKILL,
		RES_GLOBAL_CONF_TYPE_MVP_RATE_TQUATARYKILL,
		RES_GLOBAL_CONF_TYPE_MVP_RATE_PENTAKILL,
		RES_GLOBAL_CONF_TYPE_RECORDER_KINGTIME_VIDEO210KILLTOTALTIME,
		RES_GLOBAL_CONF_TYPE_SOLDIER_SIGHT_RADIUS,
		RES_GLOBAL_CONF_TYPE_FOW_TOWER_SIGHT_RADIUS,
		RES_GLOBAL_CONF_TYPE_1V1_GUIDE_HERO_AD,
		RES_GLOBAL_CONF_TYPE_1V1_GUIDE_HERO_AP,
		RES_GLOBAL_CONF_TYPE_5V5_GUIDE_HERO_AD,
		RES_GLOBAL_CONF_TYPE_5V5_GUIDE_HERO_AP,
		RES_GLOBAL_CONF_TYPE_1V1_GUIDE_LEVEL_AD,
		RES_GLOBAL_CONF_TYPE_1V1_GUIDE_LEVEL_AP,
		RES_GLOBAL_CONF_TYPE_5V5_GUIDE_LEVEL_AD,
		RES_GLOBAL_CONF_TYPE_5V5_GUIDE_LEVEL_AP,
		RES_GLOBAL_CONF_TYPE_FOW_ATTACK_SHOWMARK_DURATION,
		RES_GLOBAL_CONF_TYPE_RAND_USUALTASK_TIME,
		RES_GLOBAL_CONF_TYPE_MENTOR_GET_APPRENTICE_MINLV_LIMIT,
		RES_GLOBAL_CONF_TYPE_MENTOR_GET_MENTOR_MAXLV_LIMIT,
		RES_GLOBAL_CONF_TYPE_MENTOR_GET_APPRENTICE_MINGRADE_LIMIT,
		RES_GLOBAL_CONF_TYPE_ADDCOINLIMIT_CREDIT,
		RES_GLOBAL_CONF_TYPE_CREDITADDCOINLIMIT_VALUE,
		RES_GLOBAL_CONF_TYPE_REDUCECOINLIMIT_CREDIT,
		RES_GLOBAL_CONF_TYPE_CREDITREDUCECOINLIMIT_VALUE,
		RES_GLOBAL_CONF_TYPE_ADDCOINLIMIT_ACTIVE,
		RES_GLOBAL_CONF_TYPE_ACTIVEADDCOINLIMIT_VALUE,
		RES_GLOBAL_CONF_TYPE_LADDERADDCOINLIMIT_VALUE,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_MAX_WIN_NUM,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_SCORE_RATIO,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_GOODEVAL_LIMIT,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_BADEVAL_LIMIT,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_MAX_SCORE,
		RES_GLOBAL_CONF_TYPE_NEWBIE_RECOMMEND_HEROTYPE1,
		RES_GLOBAL_CONF_TYPE_NEWBIE_RECOMMEND_HEROTYPE2,
		RES_GLOBAL_CONF_TYPE_NEWBIE_RECOMMEND_HEROTYPE3,
		RES_GLOBAL_CONF_TYPE_1V1_SETTLE_TIME_LIMIT,
		RES_GLOBAL_CONF_TYPE_CHG_PLAYER_NAME_CD,
		RES_GLOBAL_CONF_TYPE_CHG_GUILD_NAME_CD,
		RES_GLOBAL_CONF_TYPE_COIN_TO_SYMBOL_RATE,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_EVAL_LIMIT,
		RES_GLOBAL_CONF_TYPE_FACTORY_SHOP_MONTH_CARD_ID,
		RES_GLOBAL_CONF_TYPE_FACTORY_SHOP_WEEK_CARD_ID,
		RES_GLOBAL_CONF_TYPE_HEROINFO_IS_SHOW_2D_ID,
		RES_GLOBAL_CONF_TYPE_INTIMACY_LIMITTIME,
		RES_GLOBAL_CONF_TYPE_LOSE_MVP_ADJUST_PARAM,
		RES_GLOBAL_CONF_TYPE_CORONA_COIN,
		RES_GLOBAL_CONF_TYPE_DEADINFO_ATTACK_INTERVALTIME_MAX,
		RES_GLOBAL_CONF_TYPE_DEADINFO_STATTIME_MAX,
		RES_GLOBAL_CONF_TYPE_LADDER_REWARD_SKIN_ID,
		RES_GLOBAL_CONF_TYPE_DELCREDIT_WARN,
		RES_GLOBAL_CONF_TYPE_DELCREDIT_PUNISH,
		RES_GLOBAL_CONF_TYPE_DELCREDIT_DROP,
		RES_GLOBAL_CONF_TYPE_CUSTOM_EQUIP_MIN_WIN_NUM,
		RES_GLOBAL_CONF_TYPE_REMOVESTUDENT_PUNISH,
		RES_GLOBAL_CONF_TYPE_RECRUITMENT_PVPEXP,
		RES_GLOBAL_CONF_TYPE_RECRUITMENT_PVPCOIN,
		RES_GLOBAL_CONF_TYPE_RECRUITMENT_NUMLIMIT,
		RES_GLOBAL_CONF_TYPE_RECRUITMENT_LEVELLIMIT,
		RES_GLOBAL_CONF_TYPE_RECRUITMENT_REMOVE_DAY,
		RES_GLOBAL_CONF_TYPE_INTIMACY_REQUESTTIME,
		RES_GLOBAL_CONF_TYPE_RECRUITMENT_SUPER_LEVEL,
		RES_GLOBAL_CONF_TYPE_DEFAULT_STUDENTNUM,
		RES_GLOBAL_CONF_TYPE_REMOVEMASTER_TIMELIMIT,
		RES_GLOBAL_CONF_TYPE_REMOVEMASTER_PUNISHTIME,
		RES_GLOBAL_CONF_TYPE_LADDER_REWARD_REQUIRE,
		RES_GLOBAL_CONF_TYPE_PASS_NEWBIE_PROCESS,
		RES_GLOBAL_CONF_TYPE_INTIMACY_DISPALY,
		RES_GLOBAL_CONF_TYPE_RECOMSTUDENT_MINLVL,
		RES_GLOBAL_CONF_TYPE_LBS_SEARCH_RADIUS,
		RES_GLOBAL_CONF_TYPE_1V1_SETTLE_WAIT_TIMEOUT,
		RES_GLOBAL_CONF_TYPE_1V1_SETTLE_PING_INTERVAL,
		RES_GLOBAL_CONF_TYPE_RECORDER_FREERECORDER_ANDROIDMINSPACELIMIT,
		RES_GLOBAL_CONF_TYPE_RECORDER_FREERECORDER_IOSMINSPACELIMIT,
		RES_GLOBAL_CONF_TYPE_CAMP1_KILL_BARON_SOLDIER_WAVE,
		RES_GLOBAL_CONF_TYPE_CAMP2_KILL_BARON_SOLDIER_WAVE,
		RES_GLOBAL_CONF_TYPE_TRAINLEVEL_CONFIRM_LEVEL_LIMIT,
		RES_GLOBAL_CONF_TYPE_OPEN_TP_DOWNLOAD_WATCH,
		RES_GLOBAL_CONF_TYPE_OPEN_TP_WATCH,
		RES_GLOBAL_CONF_TYPE_OPEN_TP_PRINT_SCRN,
		RES_GLOBAL_CONF_TYPE_REQUEST_INTIMACY_VALUE,
		RES_GLOBAL_CONF_TYPE_DISPLAY_INTIMACY_VALUE,
		RES_GLOBAL_CONF_TYPE_XUNYOUEND_CHECK_INTERVAL,
		RES_GLOBAL_CONF_TYPE_ARENA_SETTLE_CDTIME,
		RES_GLOBAL_CONF_TYPE_KILL_ALL_TOWER_ADD_SOLDIER_MAXHP,
		RES_GLOBAL_CONF_TYPE_KILL_ALL_TOWER_ADD_SOLDIER_PHYCATTACK,
		RES_GLOBAL_CONF_TYPE_KILL_ALL_TOWER_ADD_SOLDIER_MAGCATTACK,
		RES_GLOBAL_CONF_TYPE_KILL_ALL_TOWER_ADD_SOLDIER_PHYCDEFNED,
		RES_GLOBAL_CONF_TYPE_KILL_ALL_TOWER_ADD_SOLDIER_MAGCDEFEND,
		RES_GLOBAL_CONF_TYPE_KILL_ALL_TOWER_ADD_SOLDIER_DROPCOIN,
		RES_GLOBAL_CONF_TYPE_KILL_ALL_TOWER_ADD_SOLDIER_DROPEXP,
		RES_GLOBAL_CONF_TYPE_KILL_ALL_TOWER_ADD_SOLDIER_SHAPESCALE,
		RES_GLOBAL_CONF_TYPE_DEAD_MAXTIME,
		RES_GLOBAL_CONF_TYPE_DEAD2HANGUP_TIME,
		RES_GLOBAL_CONF_TYPE_CHAT_COMPLAINT_DAYLIMIT,
		RES_GLOBAL_CONF_TYPE_NODEL_MASTERPOINT_DAY,
		RES_GLOBAL_CONF_TYPE_SHOW_DEFAULT_HEADIMG_START_LADDERLEVEL,
		RES_GLOBAL_CONF_TYPE_AP_ORGAN_DAMAGE_ADD_RATIO,
		RES_GLOBAL_CONF_TYPE_INTIMACY_HEROCP,
		RES_GLOBAL_CONF_TYPE_INTIMACY_LOVER_HEADID,
		RES_GLOBAL_CONF_TYPE_INTIMACY_GAY_HEADID,
		RES_GLOBAL_CONF_TYPE_INTIMACY_SIDEKICK_HEADID,
		RES_GLOBAL_CONF_TYPE_INTIMACY_BESTIE_HEADID,
		RES_GLOBAL_CONF_TYPE_INTIMACY_MIDDLE_VALUE,
		RES_GLOBAL_CONF_TYPE_INTIMACY_HIGH_VALUE,
		RES_GLOBAL_CONF_TYPE_GET_INTIMACY_INTERVAL_TIME,
		RES_GLOBAL_CONF_TYPE_RESERVE_MSG_SWITCH,
		RES_GLOBAL_CONF_TYPE_RESERVE_MSG_INTIMACY_LIMIT,
		RES_GLOBAL_CONF_TYPE_VERIFYSVR_ARENA_BATTLEHEROID,
		RES_GLOBAL_CONF_TYPE_WANGZHECNT_BEGINSEASONID,
		RES_GLOBAL_CONF_TYPE_RESERVEMSGREQ_CD,
		RES_GLOBAL_CONF_TYPE_MAX
	}
}
