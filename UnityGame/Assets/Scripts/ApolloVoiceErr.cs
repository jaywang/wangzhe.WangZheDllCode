using System;

public enum ApolloVoiceErr
{
	APOLLO_VOICE_SUCC,
	APOLLO_VOICE_NONE,
	APOLLO_VOICE_UNKNOWN = 3,
	APOLLO_VOICE_STATE_ERR,
	APOLLO_VOICE_CREATE_ERR,
	APOLLO_VOICE_IN_ROOM,
	APOLLO_VOICE_JOIN_TIMEOUT = 50,
	APOLLO_VOICE_JOIN_SUCC,
	APOLLO_VOICE_JOIN_NOTIN,
	APOLLO_VOICE_JOIN_FAIL,
	APOLLO_VOICE_JOIN_URL,
	APOLLO_VOICE_NET_TIMEOUT = 121,
	APOLLO_VOICE_PERMISSION_MIC = 200,
	APOLLO_VOICE_TVE_CREATE = 300,
	APOLLO_VOICE_TVE_NULL,
	APOLLO_VOICE_TVE_STOP,
	APOLLO_VOICE_TVE_INIT,
	APOLLO_VOICE_TVE_START,
	APOLLO_VOICE_CDNV_CREATE = 400,
	APOLLO_VOICE_CDNV_NULL,
	APOLLO_VOICE_CDNV_QUIT
}
