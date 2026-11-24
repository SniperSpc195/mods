using System;
using System.Collections.Generic;
using StUtility;
using UnityEngine;

namespace Sting.Script.Engine
{
	public class CActionSeq
	{
		public enum Flg
		{
			Reminiscence = 0,
			ChoiceYes = 1,
			HitAction = 2,
			_MAX = 0x80
		}

		private enum SeqState
		{
			Exit = 0,
			Quit = 1,
			Cont = 2
		}

		public enum SeqType
		{
			Main = 0,
			SubTop = 1,
			SubBtm = 32,
			Max = 33
		}

		public enum WaitMode
		{
			None = 0,
			Wait = 1
		}

		public static readonly int COMMAND_SIZE;

		public const int FILE_ADDR_SIZE = 4;

		public const int EXIT_SEQ_POINTER = -1;

		private const int NODE_DEFAULT_MAX = 256;

		private const int SUBSEQ_MAX = 32;

		private const int VAL_I_MAX = 128;

		private const int VAL_F_MAX = 32;

		private const int STR_MAX = 16;

		private CScriptHeader m_FileHeader;

		public CScriptNode m_ScrNode;

		public CScriptTerritory[] m_Territory;

		private byte[] m_ScriptBin;

		private int m_PackFileNo;

		private int m_FileSize;

		private int m_TopSeq;

		private SeqState m_State;

		private SeqType m_SeqType;

		private WaitMode m_WaitMode;

		private int m_TickCount;

		private float m_TickFrm;

		private float m_TickSpd;

		public int m_CmdInfoSize;

		public int m_LastCmdLineNum;

		public string m_LastCmdLineFn;

		public CPrmBit m_Flg;

		public CPrmValS64 m_ValI;

		public CPrmValF32 m_ValF;

		public CPrmStr m_Str;

		public Action m_RecreateCallBack;

		public bool m_IsAdv;

		public GameObject m_GameObj;

		public CSkill m_Skill;

		public CActionSeq(CPack i_Pack, string i_FileName, ushort i_NodeMax = 256)
		{
		}

		public CActionSeq(CPack i_Pack, int i_PackFileNo, int i_FileOffset, ushort i_NodeMax = 256)
		{
		}

		public CActionSeq(byte[] i_FileBuffer, int i_FileOffset, ushort i_NodeMax = 256)
		{
		}

		private void Setting(byte[] i_AllBin, int i_SecurityFileSize, int i_SecurityFileOffset, int i_FileOffset, ushort i_NodeMax)
		{
		}

		private void Setting(byte[] i_FileBuffer, int i_FileOffset, ushort i_NodeMax)
		{
		}

		private void SettingCore(byte[] i_FileBuffer, int i_FileOffset)
		{
		}

		private byte[] SecurityDecode(byte[] i_Buffer, int i_FileSize, int i_FileOffset)
		{
			return null;
		}

		private byte[] SecurityDecodeOriginalKey(byte[] i_Buffer, uint i_TopOffset, uint i_BufSize, int i_Lv)
		{
			return null;
		}

		private byte[] CompressDecode(byte[] i_Buffer)
		{
			return null;
		}

		private void Init(ushort i_NodeMax, bool i_bPrmClear)
		{
		}

		private void Free()
		{
		}

		private void Clear(bool i_bPrmClear)
		{
		}

		public void CopyData(CActionSeq i_CopySeq)
		{
		}

		public bool IsScript(int i_ScrID)
		{
			return false;
		}

		public void Trig(int i_ScrID, bool i_Check)
		{
		}

		public int Tick()
		{
			return 0;
		}

		private int _Tick()
		{
			return 0;
		}

		private int TickSub(int i_Ptr)
		{
			return 0;
		}

		public void AddFunction(int i_ReturnOffset, byte i_RetMold, long i_RetParamData, short i_RetParamInfo)
		{
		}

		public void DelFunction()
		{
		}

		public int GetFuncReturnInfo(ref byte i_RetMold, ref SNumberParam64Bit i_RetParam)
		{
			return 0;
		}

		public void PushFunction(int i_SeqNo)
		{
		}

		public void PopFunction(int i_SeqNo)
		{
		}

		public List<string> GetResourceInfoList(int i_Index)
		{
			return null;
		}

		public int GetTopSeq()
		{
			return 0;
		}

		public bool IsSeq(SeqType seqNo = SeqType.Main)
		{
			return false;
		}

		public int GetCurSeq(SeqType seqNo = SeqType.Main)
		{
			return 0;
		}

		public void SetSeq(SeqType i_SeqNo, int i_CurSeq)
		{
		}

		public void SetSeqOffset(SeqType i_SeqNo, int i_Offset)
		{
		}

		public int GetCurSeqOffset(SeqType i_SeqNo)
		{
			return 0;
		}

		public void ClearSeq(SeqType i_SeqNo = SeqType.Main)
		{
		}

		public byte[] GetBinary()
		{
			return null;
		}

		public int GetAddress(int i_Offset)
		{
			return 0;
		}

		public int GetOffset(int i_Addr)
		{
			return 0;
		}

		public void SetVWaitCounter(int i_Counter)
		{
		}

		public int GetVWaitCounter()
		{
			return 0;
		}

		public void SetRecVWait(int i_Wait)
		{
		}

		public int GetRecVWait()
		{
			return 0;
		}

		public bool UpdateVWait()
		{
			return false;
		}

		private CScriptHeader GetFileHeader()
		{
			return null;
		}

		public ushort GetFileNo()
		{
			return 0;
		}

		public int GetFileSize()
		{
			return 0;
		}

		public SeqType GetSeqType()
		{
			return SeqType.Main;
		}

		public void SetSeqType(SeqType i_SeqType)
		{
		}

		public WaitMode GetWaitMode()
		{
			return WaitMode.None;
		}

		public void SetWaitMode(WaitMode i_Mode)
		{
		}

		private int GetTickCount()
		{
			return 0;
		}

		private void SetTickCount(int i_Tickcount)
		{
		}

		private void SetTickSpd(float i_Spd)
		{
		}

		private float GetTickSpd()
		{
			return 0f;
		}

		public void FlgClear()
		{
		}

		public void ValIClear()
		{
		}

		public void ValFClear()
		{
		}

		public void StrClear()
		{
		}

		public CScriptVar GetAutoVar()
		{
			return null;
		}

		public void Exit()
		{
		}

		public bool IsExit()
		{
			return false;
		}

		public void Quit()
		{
		}

		public bool IsQuit()
		{
			return false;
		}

		public void Cont()
		{
		}

		public bool IsCont()
		{
			return false;
		}
	}
}
