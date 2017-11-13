using System;
using tsf4g_tdr_csharp;

namespace ResData
{
	public class ResFakeAcntSkill : tsf4g_csharp_interface, IUnpackable
	{
		public uint dwLevel;

		public uint dwSkillNum;

		public uint[] SkillId;

		public static readonly uint BASEVERSION = 1u;

		public static readonly uint CURRVERSION = 1u;

		public ResFakeAcntSkill()
		{
			this.SkillId = new uint[10];
		}

		private void TransferData()
		{
		}

		public TdrError.ErrorType construct()
		{
			return TdrError.ErrorType.TDR_NO_ERROR;
		}

		public TdrError.ErrorType unpack(ref byte[] buffer, int size, ref int usedSize, uint cutVer)
		{
			if (buffer == null || buffer.GetLength(0) == 0 || size > buffer.GetLength(0))
			{
				return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
			}
			TdrReadBuf tdrReadBuf = new TdrReadBuf(ref buffer, size);
			TdrError.ErrorType result = this.unpack(ref tdrReadBuf, cutVer);
			usedSize = tdrReadBuf.getUsedSize();
			return result;
		}

		public TdrError.ErrorType unpack(ref TdrReadBuf srcBuf, uint cutVer)
		{
			if (cutVer == 0u || ResFakeAcntSkill.CURRVERSION < cutVer)
			{
				cutVer = ResFakeAcntSkill.CURRVERSION;
			}
			if (ResFakeAcntSkill.BASEVERSION > cutVer)
			{
				return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
			}
			TdrError.ErrorType errorType = srcBuf.readUInt32(ref this.dwLevel);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			errorType = srcBuf.readUInt32(ref this.dwSkillNum);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			for (int i = 0; i < 10; i++)
			{
				errorType = srcBuf.readUInt32(ref this.SkillId[i]);
				if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
				{
					return errorType;
				}
			}
			this.TransferData();
			return errorType;
		}

		public TdrError.ErrorType load(ref byte[] buffer, int size, ref int usedSize, uint cutVer)
		{
			if (buffer == null || buffer.GetLength(0) == 0 || size > buffer.GetLength(0))
			{
				return TdrError.ErrorType.TDR_ERR_INVALID_BUFFER_PARAMETER;
			}
			TdrReadBuf tdrReadBuf = new TdrReadBuf(ref buffer, size);
			TdrError.ErrorType result = this.load(ref tdrReadBuf, cutVer);
			usedSize = tdrReadBuf.getUsedSize();
			return result;
		}

		public TdrError.ErrorType load(ref TdrReadBuf srcBuf, uint cutVer)
		{
			srcBuf.disableEndian();
			if (cutVer == 0u || ResFakeAcntSkill.CURRVERSION < cutVer)
			{
				cutVer = ResFakeAcntSkill.CURRVERSION;
			}
			if (ResFakeAcntSkill.BASEVERSION > cutVer)
			{
				return TdrError.ErrorType.TDR_ERR_CUTVER_TOO_SMALL;
			}
			TdrError.ErrorType errorType = srcBuf.readUInt32(ref this.dwLevel);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			errorType = srcBuf.readUInt32(ref this.dwSkillNum);
			if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
			{
				return errorType;
			}
			for (int i = 0; i < 10; i++)
			{
				errorType = srcBuf.readUInt32(ref this.SkillId[i]);
				if (errorType != TdrError.ErrorType.TDR_NO_ERROR)
				{
					return errorType;
				}
			}
			this.TransferData();
			return errorType;
		}
	}
}
