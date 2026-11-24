using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CFontType : MonoBehaviour
{
	public enum LANG
	{
		Ja = 0,
		En = 1,
		Ct = 2,
		Cs = 3,
		Ko = 4,
		Max = 5,
		Default = -1
	}

	private class ICONFILE
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadSprite_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public ICONFILE _003C_003E4__this;

			public string path;

			private AsyncOperationHandle<TMP_SpriteAsset> _003Chandle_003E5__2;

			private UniTask<TMP_SpriteAsset>.Awaiter _003C_003Eu__1;

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

		public string mName;

		public int mHash;

		public string mPath;

		public ICONFILE(string name)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadSprite_003Ed__4))]
		public UniTask LoadSprite(string path)
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadFont_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<TMP_FontAsset> _003C_003Et__builder;

		public string lang;

		public string type;

		private UniTask<TMP_FontAsset>.Awaiter _003C_003Eu__1;

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
	private struct _003CLoadFonts_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private string _003Ccountry_003E5__2;

		private UniTask.Awaiter _003C_003Eu__1;

		private UniTask<TMP_FontAsset>.Awaiter _003C_003Eu__2;

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
	private bool mUseOutline;

	[SerializeField]
	private Color mFaceColor;

	[SerializeField]
	private Color mOutlineColor;

	private TextMeshProUGUI mTMPro;

	[SerializeField]
	[ReadOnly]
	private static LANG mLanguage;

	private static TMP_FontAsset m_ModifiedMainFontAsset;

	private static TMP_FontAsset m_ModifiedSubFontAsset;

	private static List<TMP_FontAsset> m_BackupMainFallback;

	private static List<TMP_FontAsset> m_BackupSubFallback;

	private static Dictionary<string, string> m_ConvIcons;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetFaceColor(Color color)
	{
	}

	public void SetOutlineColor(Color color)
	{
	}

	public static LANG GetLanguage()
	{
		return LANG.Ja;
	}

	public static void Initialize()
	{
	}

	[AsyncStateMachine(typeof(_003CLoadFonts_003Ed__18))]
	public static UniTask LoadFonts()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CLoadFont_003Ed__19))]
	private static UniTask<TMP_FontAsset> LoadFont(string lang, string type)
	{
		return default;
	}

	public static string CheckIcons(string a, GameController.PADNUM pad = GameController.PADNUM.None)
	{
		return null;
	}

	public static string GetButtonIcon(string code, GameController.PADNUM pad = GameController.PADNUM.None)
	{
		return null;
	}

	private static string GetStringKeyboard(uint pad)
	{
		return null;
	}

	public static string GetStringKeyboard2(uint pad1, uint pad2)
	{
		return null;
	}
}
