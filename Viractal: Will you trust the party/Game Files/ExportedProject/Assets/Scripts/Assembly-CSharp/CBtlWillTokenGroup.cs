using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Text;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

public class CBtlWillTokenGroup : MonoBehaviour
{
	private struct WillToken
	{
		public CBtlWillToken token;

		public CardRenderTextureSpriteRenderer.ManaKind kind;

		public List<Vector3> node;

		public List<float> nodeLength;

		public List<float> segmentLength;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CAddToken_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<Vector3?> _003C_003Et__builder;

		public CBtlWillTokenGroup _003C_003E4__this;

		public CardRenderTextureSpriteRenderer.ManaKind kind;

		public Vector3 position;

		public bool playSE;

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
	private struct _003CExChange_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string i_Kind;

		public CBtlWillTokenGroup _003C_003E4__this;

		public CancellationToken i_Cancel;

		public int i_Count;

		private Utf16ValueStringBuilder _003Csb_003E5__2;

		private int _003Ci_003E5__3;

		private Vector3 _003Cposition_003E5__4;

		private CardRenderTextureSpriteRenderer.ManaKind _003Ckind_003E5__5;

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
	private struct _003CLoad_003Ed__36 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public JsonNode i_Json;

		public CBtlWillTokenGroup _003C_003E4__this;

		private int _003Ccount_003E5__2;

		private IEnumerator<JsonNode> _003C_003E7__wrap2;

		private UniTask<Vector3?>.Awaiter _003C_003Eu__1;

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
	private float TokenSpaceX;

	[SerializeField]
	private float TokenSpaceZ;

	[SerializeField]
	private int WillColumnMax;

	[SerializeField]
	private Transform m_BasePosition;

	[SerializeField]
	private SpriteRenderer[] m_PositionMarkers;

	private List<WillToken> m_List;

	private float? m_AlignDelayFrameGoal;

	private float m_AlignDelayFrameCurrent;

	private float m_Time;

	private int? m_WillTokenMax;

	private void Start()
	{
	}

	private void Update()
	{
	}

	[AsyncStateMachine(typeof(_003CAddToken_003Ed__13))]
	public UniTask<Vector3?> AddToken(CardRenderTextureSpriteRenderer.ManaKind kind, Vector3 position, bool playSE = true)
	{
		return default;
	}

	public bool Contain(CardRenderTextureSpriteRenderer.ManaKind kind, int count)
	{
		return false;
	}

	public bool Consume(out Vector3[] positions, CardRenderTextureSpriteRenderer.ManaKind kind, int count, bool align = true)
	{
		positions = null;
		return false;
	}

	public bool Consume(CardRenderTextureSpriteRenderer.ManaKind kind, int count, bool align = true)
	{
		return false;
	}

	public int ConsumeOldest(int limit)
	{
		return 0;
	}

	[AsyncStateMachine(typeof(_003CExChange_003Ed__18))]
	public UniTask ExChange(int i_Count, string i_Kind, CancellationToken i_Cancel)
	{
		return default;
	}

	public int Delete(bool align = true, bool deleteNewbie = false)
	{
		return 0;
	}

	public void DeleteAll(int keep = 0, bool keepNewbie = false)
	{
	}

	public Vector3 GetNextTokenLocalPosition(int add)
	{
		return default;
	}

	private Vector3 GetTokenLocalPosition(int i_No)
	{
		return default;
	}

	public Vector3 GetNextTokenWorldPosition(int add)
	{
		return default;
	}

	private void InitAlign()
	{
	}

	public void Align(float i_Delay = 0f)
	{
	}

	private void UpdateTokenPosition()
	{
	}

	private Vector3 LerpByArcLength(WillToken will, float t)
	{
		return default;
	}

	public int Count()
	{
		return 0;
	}

	public void Count(out int o_Justice, out int o_Dignity, out int o_Wisdom, out int o_Mercy)
	{
		o_Justice = default;
		o_Dignity = default;
		o_Wisdom = default;
		o_Mercy = default;
	}

	public void CountOldest(int limit, out int o_Justice, out int o_Dignity, out int o_Wisdom, out int o_Mercy)
	{
		o_Justice = default;
		o_Dignity = default;
		o_Wisdom = default;
		o_Mercy = default;
	}

	public void PlaySelecting(CardRenderTextureSpriteRenderer.ManaKind kind, int count)
	{
	}

	public void StopSelecting()
	{
	}

	private void InitWillTokenMax()
	{
	}

	public void ApplyWillTokenMax()
	{
	}

	public List<int> Save()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoad_003Ed__36))]
	public UniTask Load(JsonNode i_Json)
	{
		return default;
	}
}
