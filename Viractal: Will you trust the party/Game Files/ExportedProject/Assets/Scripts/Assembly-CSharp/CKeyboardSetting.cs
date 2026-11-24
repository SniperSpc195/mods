using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Fork.Game;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CKeyboardSetting : SingletonMonoBehaviour<CKeyboardSetting>
{
	private enum GCON
	{
		D_UP = 0,
		D_DOWN = 1,
		D_LEFT = 2,
		D_RIGHT = 3,
		AR_UP = 4,
		AR_DOWN = 5,
		AR_LEFT = 6,
		AR_RIGHT = 7,
		A = 8,
		B = 9,
		X = 10,
		Y = 11,
		BACK = 12,
		START = 13,
		L1 = 14,
		R1 = 15,
		L2 = 16,
		R2 = 17,
		L3 = 18,
		R3 = 19,
		Max = 20
	}

	private enum MODE
	{
		None = 0,
		Open = 1,
		Close = 2,
		Display = 3,
		Mapping = 4
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CKeyboardSetting _003C_003E4__this;

		private AsyncOperationHandle<IList<Sprite>> _003Chandle_003E5__2;

		private UniTask<IList<Sprite>>.Awaiter _003C_003Eu__1;

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

	private const string Version = "1.00";

	[SerializeField]
	private CUIGenericOpenClose mParentTop;

	private const int KEYLINE_MAX = 6;

	[SerializeField]
	private Transform mParentKeyLayout;

	[SerializeField]
	private Vector2 mKeyIconSize;

	[SerializeField]
	private Vector2 mKeyIconSpace;

	[SerializeField]
	private Vector2 mBtnIconSize;

	[SerializeField]
	private Vector2 mBtnIconOffset;

	[SerializeField]
	private Transform[] mParentPadLayout;

	[SerializeField]
	private Transform mParentInstructions;

	[SerializeField]
	private Color mColorInvalid;

	[SerializeField]
	private Color mColorSettingKey;

	[SerializeField]
	private Color mColorSettingBtn;

	[SerializeField]
	private Color mColorMappingKey;

	[SerializeField]
	private Color mColorConstKey;

	[SerializeField]
	private Color mColorConstBtn;

	[SerializeField]
	private TextMeshProUGUI mBuildVersion;

	private Dictionary<string, Transform> mDicKeyLayout;

	private GameController.SPRITE_ICONS mKeySprites;

	private bool mPermission;

	private bool mLangJP;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	private int mMapIndex;

	[SerializeField]
	private float mPingPongSpeed;

	private float mPingPong;

	private float mKeyAlfa;

	private Tuple<uint, Key>[] DefaultKeymapCustom;

	private Tuple<uint, Key>[] mKeymapCustom;

	private Tuple<uint, Key>[] mTmpCustom;

	private Tuple<uint, Key>[] KeymapConst;

	private Dictionary<Key, string> mExchangeKey;

	private string[][] mKeyLayout;

	private string[][] mLayout_Ja;

	private string[][] mLayout_En;

	private string[] mInvalidKeys;

	private string[] mInvalidKeys_Ja;

	private string[] mInvalidKeys_En;

	private const int KEY_MAX = 128;

	private byte[] mKeyPress;

	private Tuple<string, string>[] mTopInstructions;

	private Tuple<string, string>[] mChangeInstructions;

	public void SetPermission(bool a)
	{
	}

	private void Awake()
	{
	}

	public Sprite GetKeyIcon(Key key)
	{
		return null;
	}

	public string GetKeyIconName(Key key)
	{
		return null;
	}

	private void CopyKeymap(Tuple<uint, Key>[] dst, Tuple<uint, Key>[] src)
	{
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__27))]
	public UniTask Initialize()
	{
		return default;
	}

	public bool IsExecute()
	{
		return false;
	}

	private bool IsMapping()
	{
		return false;
	}

	private void Update()
	{
	}

	private void ClearKey()
	{
	}

	private void CheckKey(Keyboard kb)
	{
	}

	private bool IsKeyOn(Key key)
	{
		return false;
	}

	private bool IsKeyEdge(Key key)
	{
		return false;
	}

	private void MakeLayout()
	{
	}

	private float LineLayout(int line, Transform parent, string[] key)
	{
		return 0f;
	}

	private void ResetLayout()
	{
	}

	private void UpdateButton(Tuple<uint, Key>[] custom, bool mapping = false)
	{
	}

	private void BlinkButton(bool update = true)
	{
	}

	private Key Mapping(CSound _sound)
	{
		return Key.None;
	}

	private bool IsMappingOk(Key key)
	{
		return false;
	}

	private bool NextMapping()
	{
		return false;
	}

	private void SetInstrunctions(Tuple<string, string>[] data)
	{
	}

	private void Save()
	{
	}

	private bool Load()
	{
		return false;
	}

	public Tuple<uint, Key>[] GetKeymapCustom()
	{
		return null;
	}

	public Tuple<uint, Key>[] GetKeymapConst()
	{
		return null;
	}
}
