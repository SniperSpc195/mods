using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Pool;

namespace Fork.Game
{
	public class CUITooltipManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			public CUITooltip i_Tooltip;

			internal bool _003C_Hide_003Eb__0()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public CUITooltipManager _003C_003E4__this;

			private int _003Ci_003E5__2;

			private GameObject[] _003C_003E7__wrap2;

			private int _003C_003E7__wrap3;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
		private struct _003C_Hide_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CUITooltip i_Tooltip;

			public CUITooltipManager _003C_003E4__this;

			public TooltipType i_Type;

			private _003C_003Ec__DisplayClass19_0 _003C_003E8__1;

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
		private Transform m_ObjectPool;

		[SerializeField]
		private AssetReferenceGameObject[] m_TooltipPrefab;

		private GameObject[] m_TooltipSource;

		private ObjectPool<CUITooltip>[] m_TooltipPool;

		private CUITooltip m_CurrentTooltip;

		private TooltipType m_CurrentTooltipType;

		public static CUITooltipManager Instance { get; private set; }

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__11))]
		private UniTaskVoid Start()
		{
			return default;
		}

		private void OnDestroy()
		{
		}

		private CUITooltip OnCreateTooltip(TooltipType i_Type)
		{
			return null;
		}

		private void OnTakeTooltip(CUITooltip i_Tooltip)
		{
		}

		private void OnReturnTooltip(CUITooltip i_Tooltip)
		{
		}

		private CUITooltip _Show(TooltipType i_Type, Vector2 i_ViewportPosition, string i_Text, float i_MinWidth, float i_MaxWidth)
		{
			return null;
		}

		private CUITooltip _Show(TooltipType i_Type, Vector2 i_ViewportPosition, Utf16ValueStringBuilder i_StringBuilder, float i_MinWidth, float i_MaxWidth)
		{
			return null;
		}

		private void _HideCurrent()
		{
		}

		[AsyncStateMachine(typeof(_003C_Hide_003Ed__19))]
		private UniTask _Hide(TooltipType i_Type, CUITooltip i_Tooltip)
		{
			return default;
		}

		private bool _IsShow()
		{
			return false;
		}

		public static CUITooltip Show(Vector2 i_ViewportPosition, string i_Text, float i_MinWidth = -1f, float i_MaxWidth = -1f)
		{
			return null;
		}

		public static CUITooltip Show(Vector2 i_ViewportPosition, Utf16ValueStringBuilder i_StringBuilder, float i_MinWidth = -1f, float i_MaxWidth = -1f)
		{
			return null;
		}

		public static CUITooltip Show(TooltipType i_Type, Vector2 i_ViewportPosition, string i_Text, float i_MinWidth = -1f, float i_MaxWidth = -1f)
		{
			return null;
		}

		public static void Hide()
		{
		}

		public static bool IsShow()
		{
			return false;
		}
	}
}
