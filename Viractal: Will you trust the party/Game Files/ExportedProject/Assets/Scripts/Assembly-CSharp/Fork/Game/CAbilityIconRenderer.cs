using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace Fork.Game
{
	public class CAbilityIconRenderer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass19_0
		{
			public AsyncOperationHandle<IList<IResourceLocation>> locations;

			internal bool _003CPreloadAbilityIcons_003Eb__0()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetAbilityIcon_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RenderTexture> _003C_003Et__builder;

			public int i_Width;

			public int i_Height;

			public string i_SkillAbilityID;

			public CancellationToken i_CancellationToken;

			private RenderTexture _003Cresult_003E5__2;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPreloadAbilityIcons_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CancellationToken i_CancellationToken;

			public CAbilityIconRenderer _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRender_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CAbilityIconRenderer _003C_003E4__this;

			public CancellationToken i_CancellationToken;

			public RenderTexture i_Destination;

			public string i_SkillAbilityID;

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

		private static CAbilityIconRenderer Instance;

		private static readonly int EdgeColor;

		private static readonly int MultiColor;

		private static readonly int LayerMaskMap;

		private static readonly int NormalMap;

		[SerializeField]
		private Camera m_TargetCamera;

		[SerializeField]
		private MeshRenderer m_Icon;

		[SerializeField]
		private GameObject m_AbilityIconPrefab;

		private MaterialPropertyBlock m_Properties;

		private bool m_Prepared;

		private AsyncOperationHandle<IList<Texture2D>> m_AbilityIconImages;

		private Dictionary<string, Texture2D> m_AbilityIconImageCache;

		[AsyncStateMachine(typeof(_003CGetAbilityIcon_003Ed__5))]
		public static UniTask<RenderTexture> GetAbilityIcon(string i_SkillAbilityID, int i_Width, int i_Height, CancellationToken i_CancellationToken = default(CancellationToken))
		{
			return default;
		}

		public static GameObject GetAbilityPrefab()
		{
			return null;
		}

		public static bool TryGetAbilityMaterial(string i_ID, out Texture2D o_Color, out Texture2D o_Normal, out Color o_BaseColor, out Color o_EdgeColor)
		{
			o_Color = null;
			o_Normal = null;
			o_BaseColor = default;
			o_EdgeColor = default;
			return false;
		}

		private bool _TryGetAbilityMaterial(string i_ID, out Texture2D o_Color, out Texture2D o_Normal, out Color o_BaseColor, out Color o_EdgeColor)
		{
			o_Color = null;
			o_Normal = null;
			o_BaseColor = default;
			o_EdgeColor = default;
			return false;
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		[AsyncStateMachine(typeof(_003CPreloadAbilityIcons_003Ed__19))]
		private UniTask PreloadAbilityIcons(CancellationToken i_CancellationToken = default(CancellationToken))
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CRender_003Ed__20))]
		private UniTask Render(string i_SkillAbilityID, RenderTexture i_Destination, CancellationToken i_CancellationToken = default(CancellationToken))
		{
			return default;
		}
	}
}
