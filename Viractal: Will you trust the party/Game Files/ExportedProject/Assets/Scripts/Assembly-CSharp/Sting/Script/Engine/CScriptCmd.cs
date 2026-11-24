using StUtility;
using UnityEngine;

namespace Sting.Script.Engine
{
	internal class CScriptCmd
	{
		public delegate int CmdFunc(int i_Ptr, CActionSeq i_ScrSeq);

		public struct CmdTable_s
		{
			public CmdFunc cmd;

			public string name;
		}

		private static CRandom m_Random;

		private static readonly CmdTable_s[] _sTbl;

		private static byte GetU8(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static sbyte GetS8(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static ushort GetU16(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static short GetS16(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static uint GetU32(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0u;
		}

		private static int GetS32(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static ulong GetU64(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0uL;
		}

		private static long GetS64(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0L;
		}

		private static float GetF32(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0f;
		}

		private static string GetString(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return null;
		}

		private static SNumberParam64Bit GetNumberParam(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return default;
		}

		private static void SetFlgParamProc(ref SNumberParam64Bit i_Info, bool i_Flag, object i_Seq)
		{
		}

		private static void SetFlgParamProc(ref SNumberParam64Bit i_Info, object i_Seq)
		{
		}

		private static void DelFlgParamProc(ref SNumberParam64Bit i_Info, object i_Seq)
		{
		}

		private static bool IsFlgParamProc(ref SNumberParam64Bit i_Info, object i_Seq)
		{
			return false;
		}

		private static void FlgParamProc(ref SNumberParam64Bit i_BaseInfo, ref SNumberParam64Bit i_SetInfo, object i_Seq)
		{
		}

		private static void FlgParamProc(ref SNumberParam64Bit i_BaseInfo, bool i_On, object i_Seq)
		{
		}

		private static string GetStringProc(ref SNumberParam64Bit i_Info, object i_Seq)
		{
			return null;
		}

		private static void SetStringParamProc(ref SNumberParam64Bit i_BaseInfo, string i_SetString, ScriptStrSetType i_Type, object i_Seq)
		{
		}

		private static CParamValue GetValParamProcMain(ref SNumberParam64Bit i_Info, long[] i_IntTopAddr, int i_IntDataMax, float[] i_FloatTopAddr, int i_FloatDataMax, object i_Seq)
		{
			return null;
		}

		private static CParamValue GetValParamProc(ref SNumberParam64Bit i_Info, object i_Seq)
		{
			return null;
		}

		private static void SetValParamProcMain(ref SNumberParam64Bit i_Info, ref SNumberParam64Bit i_Val, long[] i_IntTopAddr, int i_IntDataMax, float[] i_FloatTopAddr, int i_FloatDataMax, ScriptValSetType i_Type, object i_Seq)
		{
		}

		private static void SetValParamProc(ref SNumberParam64Bit i_Info, ref SNumberParam64Bit i_Val, ScriptValSetType i_Type, object i_Seq)
		{
		}

		private static void SetValParamProc(ref SNumberParam64Bit i_Info, long i_Num, ScriptValSetType i_Type, object i_Seq)
		{
		}

		private static void SetValParamProcF(ref SNumberParam64Bit i_Info, float i_Num, ScriptValSetType i_Type, object i_Seq)
		{
		}

		private static long GetDataInt64(ref SNumberParam64Bit i_Info, object i_Seq)
		{
			return 0L;
		}

		private static int GetDataInt32(ref SNumberParam64Bit i_Info, object i_Seq)
		{
			return 0;
		}

		private static short GetDataInt16(ref SNumberParam64Bit i_Info, object i_Seq)
		{
			return 0;
		}

		private static float GetDataFloat(ref SNumberParam64Bit i_Info, object i_Seq)
		{
			return 0f;
		}

		private static bool GetDataBool(ref SNumberParam64Bit i_Info, object i_Seq)
		{
			return false;
		}

		private static CScriptString GetDataString(ref SNumberParam64Bit i_Info, object i_Seq)
		{
			return null;
		}

		private static SNumberParam64Bit GetDataNumberParam64_CallAddr(int i_Ptr, object i_Seq, CScriptString i_ScriptString = null)
		{
			return default;
		}

		private static long GetDataInt64_CallAddr(int i_Ptr, object i_Seq)
		{
			return 0L;
		}

		private static int GetDataInt32_CallAddr(int i_Ptr, object i_Seq)
		{
			return 0;
		}

		private static short GetDataInt16_CallAddr(int i_Ptr, object i_Seq)
		{
			return 0;
		}

		private static sbyte GetDataInt8_CallAddr(int i_Ptr, object i_Seq)
		{
			return 0;
		}

		private static float GetDataFloat_CallAddr(int i_Ptr, object i_Seq)
		{
			return 0f;
		}

		private static bool GetDataBool_CallAddr(int i_Ptr, object i_Seq)
		{
			return false;
		}

		private static void GetDataString_CallAddr(int i_Ptr, object i_Seq, CScriptString i_String)
		{
		}

		private static int GetAddr(object i_Seq, int i_Offset)
		{
			return 0;
		}

		private static void SetExit(CActionSeq i_ScrSeq)
		{
		}

		private static string GetXlsxData(int i_Ptr, CActionSeq i_ScrSeq, int i_DataIndex)
		{
			return null;
		}

		private static Color GetColor(int i_ColorType, float i_Alpha)
		{
			return default;
		}

		private static int _Dummy(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _Nop(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _Exit(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _Cont(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _Printf(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _VWait(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _Goto(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _SubStart(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _SubEnd(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _SubEndWait(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _FuncCall(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _Return(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _InfinityWait(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _FlgSw(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _FlgSet(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _ValSet(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _StrSet(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _JumpIf(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _JumpSwitch(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int _ValRand(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int PlayBGM(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int PlaySE(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int PlaySE3D(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int PlaySELinkEffect(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int PlaySELinkCharacter(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static CCharDef GetActor(CActionSeq i_ScrSeq)
		{
			return null;
		}

		private static CCharDef GetSelf(CActionSeq i_ScrSeq)
		{
			return null;
		}

		private static int CountActSkillEffect(CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static CSkill GetActSkill(CActionSeq i_ScrSeq)
		{
			return null;
		}

		private static CSkillEffect GetActSkillEffects(CActionSeq i_ScrSeq, int i_Index)
		{
			return null;
		}

		public static CSkillEffect.TargetContext? GetMainTarget(CActionSeq i_ScrSeq, int index)
		{
			return null;
		}

		private static CSkillEffect.TargetContext? GetSubTarget(CActionSeq i_ScrSeq, int index)
		{
			return null;
		}

		private static int PlayMotion(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int WaitMotion(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int SetMotionSpeed(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int ApproachTarget(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int Leave(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int Move2Node(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int ChangeForward(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int ReturnForward(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int LookHomePosition(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int PlayEffect(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static CEffectHandle PlayEffect(CCharDef self, ActionWork.AttachDst node, string name, ActionWork.AttachType attachPosition, ActionWork.AttachType attachScale, ActionWork.AttachType attachRotation)
		{
			return null;
		}

		private static CEffectHandle PlayEffect(CCharDef self, string effectName, string attachName, ActionWork.AttachType attachPosition, ActionWork.AttachType attachScale, ActionWork.AttachType attachRotation)
		{
			return null;
		}

		private static CEffectHandle PlayEffect(string effectName, Transform parent, ActionWork.AttachType attachPosition, ActionWork.AttachType attachScale, ActionWork.AttachType attachRotation)
		{
			return null;
		}

		private static int SetEffectPosition(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int SetEffectScale(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int SetEffectAngle(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int WaitEffect(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int PlayEffect2Target(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static void PlayEffect(string name, Vector3 position)
		{
		}

		private static int GetMainScene(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int ActivateBlur(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int DeactivateBlur(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int GetUnitID(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int GetSkillID(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int GetChargingWillToken(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int StopEffect(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int PlayEffect2Child(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int WaitHit(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int EnableEndlessAction(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int DisableEndlessAction(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int GetSkillEffectTargetGroup(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int SetModelScaleOffset(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int StartCameraQuake(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int MoveCameraDistance(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int RestoreCameraDistance(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int MoveCameraPositionY(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int RestoreCameraPositionY(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int MoveCameraLookAtY(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int RestoreCameraLookAtY(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int MoveFieldCameraPosition(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int RestoreFieldCameraPosition(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int MoveFieldCameraZoom(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int RestoreFieldCameraZoom(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int GetStealResult(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int GetInstantDeathResult(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int WaitClearingCloud(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		private static int GetChangeDrResult(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return 0;
		}

		public static void Init(CScriptNode i_ScrNode)
		{
		}

		public static CmdFunc GetCmd(int i_SeqID)
		{
			return null;
		}

		public static string GetName(int i_SeqID)
		{
			return null;
		}

		public static bool IsEnd(int i_Ptr, CActionSeq i_ScrSeq)
		{
			return false;
		}
	}
}
