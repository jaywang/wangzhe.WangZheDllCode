using System;

namespace CSProtocol
{
	public enum CS_SALERECOMMEND_ERRCODE
	{
		CS_SALERECOMMEND_ERR_SYS = 1,
		CS_SALERECOMMEND_ERR_ID,
		CS_SALERECOMMEND_ERR_OUTDATE,
		CS_SALERECOMMEND_ERR_DUP,
		CS_SALERECOMMEND_ERR_PAY,
		CS_SALERECOMMEND_ERR_MONEY,
		CS_SALERECOMMEND_ERR_ITEM,
		CS_SALERECOMMEND_ERR_ITEM_INVALID,
		CS_SALERECOMMEND_ERR_BUYFAIL,
		CS_SALERECOMMEND_ERR_INVALDITEM
	}
}