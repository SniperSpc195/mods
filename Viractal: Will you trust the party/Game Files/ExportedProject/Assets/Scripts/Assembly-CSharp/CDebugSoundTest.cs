using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using TMPro;
using UnityEngine;

public class CDebugSoundTest : MonoBehaviour
{
	private enum TYPE
	{
		Bgm = 0,
		Se = 1,
		Voice = 2,
		Binaural = 3,
		Aisac = 4
	}

	private enum MENU
	{
		Bgm_0 = 0,
		Bgm_1 = 1,
		Se = 2,
		Voice = 3,
		Binaural = 4,
		Aisac = 5
	}

	private class REQUEST
	{
		public long mHandle;

		public string mName;

		public CSoundChannel mSc;

		public CSound.Status mStat;

		private float mWait;

		public bool IsValid()
		{
			return false;
		}

		public CSound.Status GetStatus()
		{
			return CSound.Status.Stop;
		}

		public REQUEST(long h, string name)
		{
		}

		public REQUEST(CSoundChannel sc)
		{
		}
	}

	private enum MODE
	{
		None = 0,
		End = 1,
		TopSelect = 2,
		SubMenu = 3
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CRoundSE_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public long handle;

		private Vector3? _003Cprevpoint_003E5__2;

		private YieldAwaitable.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003C_SEPitchPlayer_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string req;

		private int[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	private CScrollMenu mTopMenu;

	[SerializeField]
	private Transform mInfoOparation;

	[SerializeField]
	private TextMeshProUGUI mLBtext;

	[SerializeField]
	private TextMeshProUGUI mRBtext;

	private CScrollMenu[] mSubMenu;

	private CScrollMenu mSelectSound;

	private string[][] mReqName;

	private TYPE mSelectType;

	private MENU mSelectMenu;

	private List<REQUEST> mReqBgm;

	private List<REQUEST> mReqSe;

	private List<REQUEST> mReqVoice;

	private MODE mMode;

	private bool[] mJudg4;

	private bool[] mJudg2;

	private void Awake()
	{
	}

	public void Go(Vector2 position)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	private string[] Sort(string[] org)
	{
		return null;
	}

	private void Update()
	{
	}

	private void WriteEffect()
	{
	}

	private void LRControle(bool IsControl, bool IsOnline, GamePad pad)
	{
	}

	private long _SE3DPlay(string req)
	{
		return 0L;
	}

	[AsyncStateMachine(typeof(_003CRoundSE_003Ed__27))]
	private UniTask RoundSE(long handle)
	{
		return default;
	}

	private void _SEPitchPlay(string req)
	{
	}

	[AsyncStateMachine(typeof(_003C_SEPitchPlayer_003Ed__29))]
	private UniTask _SEPitchPlayer(string req)
	{
		return default;
	}
}
