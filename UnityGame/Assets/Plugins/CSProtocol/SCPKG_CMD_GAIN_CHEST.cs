using Assets.Scripts.Common;
using System;
using tsf4g_tdr_csharp;

namespace CSProtocol
{
	public class SCPKG_CMD_GAIN_CHEST : ProtocolObject
	{
		public int iActId;

		public byte[] szGainChestId;

		public ushort wTitleLen;

		public sbyte[] szChestTitle;

		public ushort wContentLen;

		public sbyte[] szChestContent;

		public int iResult;

		public static readonly uint BASEVERSION = 1u;

		public static readonly uint CURRVERSION = 1u;

		public static readonly uint LENGTH_szGainChestId = 256u;

		public static readonly int CLASS_ID = 1061;

		public SCPKG_CMD_GAIN_CHEST()
		{
			this.szGainChestId = new byte[256];
			this.szChestTitle = new sbyte[128];
			this.szChestContent = new sbyte[256];
		}

		public override TdrError.ErrorType construct()
		{
			return TdrError.ErrorType.TDR_NO_ERROR;
		}

		public TdrError.ErrorType pack(ref byte[] buffer, int size, ref int usedSize, uint cutVer)
		{
			if (buffer == null || buffer.GetLength(0) == 0 || size > buffer.GetLength(0))
			{
				return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
			}
			TdrWriteBuf tdrWriteBuf = ClassObjPool<TdrWriteBuf>.Get();
			tdrWriteBuf.set(ref buffer, size);
			TdrError.ErrorType errorType = this.pack(ref tdrWriteBuf, cutVer);
			if (errorType == TdrError.ErrorType.TDR_NO_ERROR)
			{
				buffer = tdrWriteBuf.getBeginPtr();
				usedSize = tdrWriteBuf.getUsedSize();
			}
			tdrWriteBuf.Release();
			return errorType;
		}

		public override TdrError.ErrorType pack(ref TdrWriteBuf destBuf, uint cutVer)
		{
			if (cutVer == 0u || SCPKG_CMD_GAIN_CHEST.CURRVERSION < cutVer)
			{
				cutVer = SCPKG_CMD_GAIN_CHEST.CURRVERSION;
			}
			if (SCPKG_CMD_GAIN_CHEST.BASEVERSION > cutVer)
			{
				return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
			}
			TdrError.ErrorType errorType = destBuf.writeInt32(this.iActId);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			int usedSize = destBuf.getUsedSize();
			errorType = destBuf.reserve(4);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			int usedSize2 = destBuf.getUsedSize();
			int num = TdrTypeUtil.cstrlen(this.szGainChestId);
			if (num >= 256)
			{
				return TdrError.ErrorType.TDR_ERR_STR_LEN_TOO_BIG;
			}
			errorType = destBuf.writeCString(this.szGainChestId, num);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			errorType = destBuf.writeUInt8(0);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			int src = destBuf.getUsedSize() - usedSize2;
			errorType = destBuf.writeUInt32((uint)src, usedSize);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			errorType = destBuf.writeUInt16(this.wTitleLen);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			if (128 < this.wTitleLen)
			{
				return TdrError.ErrorType.TDR_ERR_REFER_SURPASS_COUNT;
			}
			if (this.szChestTitle.Length < (int)this.wTitleLen)
			{
				return TdrError.ErrorType.TDR_ERR_VAR_ARRAY_CONFLICT;
			}
			for (int i = 0; i < (int)this.wTitleLen; i++)
			{
				errorType = destBuf.writeInt8(this.szChestTitle[i]);
				if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
				{
					return errorType;
				}
			}
			errorType = destBuf.writeUInt16(this.wContentLen);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			if (256 < this.wContentLen)
			{
				return TdrError.ErrorType.TDR_ERR_REFER_SURPASS_COUNT;
			}
			if (this.szChestContent.Length < (int)this.wContentLen)
			{
				return TdrError.ErrorType.TDR_ERR_VAR_ARRAY_CONFLICT;
			}
			for (int j = 0; j < (int)this.wContentLen; j++)
			{
				errorType = destBuf.writeInt8(this.szChestContent[j]);
				if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
				{
					return errorType;
				}
			}
			errorType = destBuf.writeInt32(this.iResult);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			return errorType;
		}

		public TdrError.ErrorType unpack(ref byte[] buffer, int size, ref int usedSize, uint cutVer)
		{
			if (buffer == null || buffer.GetLength(0) == 0 || size > buffer.GetLength(0))
			{
				return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
			}
			TdrReadBuf tdrReadBuf = ClassObjPool<TdrReadBuf>.Get();
			tdrReadBuf.set(ref buffer, size);
			TdrError.ErrorType result = this.unpack(ref tdrReadBuf, cutVer);
			usedSize = tdrReadBuf.getUsedSize();
			tdrReadBuf.Release();
			return result;
		}

		public override TdrError.ErrorType unpack(ref TdrReadBuf srcBuf, uint cutVer)
		{
			if (cutVer == 0u || SCPKG_CMD_GAIN_CHEST.CURRVERSION < cutVer)
			{
				cutVer = SCPKG_CMD_GAIN_CHEST.CURRVERSION;
			}
			if (SCPKG_CMD_GAIN_CHEST.BASEVERSION > cutVer)
			{
				return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
			}
			TdrError.ErrorType errorType = srcBuf.readInt32(ref this.iActId);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			uint num = 0u;
			errorType = srcBuf.readUInt32(ref num);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			if (num > (uint)srcBuf.getLeftSize())
			{
				return TdrError.ErrorType.TDR_ERR_SHORT_BUF_FOR_READ;
			}
			if (num > (uint)this.szGainChestId.GetLength(0))
			{
				if ((ulong)num > (ulong)SCPKG_CMD_GAIN_CHEST.LENGTH_szGainChestId)
				{
					return TdrError.ErrorType.TDR_ERR_STR_LEN_TOO_BIG;
				}
				this.szGainChestId = new byte[num];
			}
			if (1u > num)
			{
				return TdrError.ErrorType.TDR_ERR_STR_LEN_TOO_SMALL;
			}
			errorType = srcBuf.readCString(ref this.szGainChestId, (int)num);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			if (this.szGainChestId[(int)(num - 1u)] != 0)
			{
				return TdrError.ErrorType.TDR_ERR_STR_LEN_CONFLICT;
			}
			int num2 = TdrTypeUtil.cstrlen(this.szGainChestId) + 1;
			if ((ulong)num != (ulong)((long)num2))
			{
				return TdrError.ErrorType.TDR_ERR_STR_LEN_CONFLICT;
			}
			errorType = srcBuf.readUInt16(ref this.wTitleLen);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			if (128 < this.wTitleLen)
			{
				return TdrError.ErrorType.TDR_ERR_REFER_SURPASS_COUNT;
			}
			this.szChestTitle = new sbyte[(int)this.wTitleLen];
			for (int i = 0; i < (int)this.wTitleLen; i++)
			{
				errorType = srcBuf.readInt8(ref this.szChestTitle[i]);
				if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
				{
					return errorType;
				}
			}
			errorType = srcBuf.readUInt16(ref this.wContentLen);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			if (256 < this.wContentLen)
			{
				return TdrError.ErrorType.TDR_ERR_REFER_SURPASS_COUNT;
			}
			this.szChestContent = new sbyte[(int)this.wContentLen];
			for (int j = 0; j < (int)this.wContentLen; j++)
			{
				errorType = srcBuf.readInt8(ref this.szChestContent[j]);
				if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
				{
					return errorType;
				}
			}
			errorType = srcBuf.readInt32(ref this.iResult);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			return errorType;
		}

		public override int GetClassID()
		{
			return SCPKG_CMD_GAIN_CHEST.CLASS_ID;
		}

		public override void OnRelease()
		{
			this.iActId = 0;
			this.wTitleLen = 0;
			this.wContentLen = 0;
			this.iResult = 0;
		}
	}
}
