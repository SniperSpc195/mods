using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

public class CardRenderTextureSpriteRenderer : SingletonMonoBehaviour<CardRenderTextureSpriteRenderer>
{
	public enum ManaKind
	{
		Dignity = 0,
		Justice = 1,
		Wisdom = 2,
		Mercy = 3,
		_Max = 4,
		None = 5
	}

	public enum Rarity
	{
		Common = 0,
		UnCommon = 1,
		Rare = 2
	}

	public enum Priority
	{
		Default = 0,
		GameRoom = 1,
		Field = 2
	}

	public enum DisplayAttackType
	{
		None = 0,
		Value = 1,
		x1 = 2,
		xValue = 3,
		Detail = 4,
		Hyphen = 5
	}

	public struct CardSymbol
	{
		public DisplayAttackType displayAttackType;

		public int displayAttackValue;

		public string displayAttackDetail;
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public string id;

		internal bool _003CGetAsyncTexture_003Eb__0()
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CGetAsyncTexture_003Ed__57 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<Texture> _003C_003Et__builder;

		public string id;

		public CancellationToken i_Cancel;

		private _003C_003Ec__DisplayClass57_0 _003C_003E8__1;

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
	private struct _003CGetCardMaterialForUGUIAsync_003Ed__63 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<Material> _003C_003Et__builder;

		public string id;

		public bool setRandomParam;

		private UniTask<Material>.Awaiter _003C_003Eu__1;

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
	private struct _003CGetCardMaterialForUGUIAsync_003Ed__64 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<Material> _003C_003Et__builder;

		public CMaster_SkillCardData card;

		public bool setRandomParam;

		private Material _003Cmat_003E5__2;

		private UniTask<Texture>.Awaiter _003C_003Eu__1;

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
	private struct _003CGetCardMaterialForUGUIAsync_003Ed__65 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<Material> _003C_003Et__builder;

		public string id;

		public Material orgMaterial;

		public bool setRandomParm;

		private UniTask<Material>.Awaiter _003C_003Eu__1;

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
	private struct _003CGetCardMaterialForUGUIAsync_003Ed__66 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<Material> _003C_003Et__builder;

		public CMaster_SkillCardData card;

		public Material orgMaterial;

		public bool setRandomParm;

		private Material _003Cmat_003E5__2;

		private UniTask<Texture>.Awaiter _003C_003Eu__1;

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
	private struct _003CRender_003Ed__79 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public CMaster_SkillCardData i_Data;

		public CardRenderTextureSpriteRenderer _003C_003E4__this;

		public CancellationToken canceltoken;

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
	private struct _003CRenderAll_003Ed__75 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CardRenderTextureSpriteRenderer _003C_003E4__this;

		public CancellationToken canceltoken;

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
	private struct _003CSetMaterialPropertyBlockForMeshRenderer_003Ed__71 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string i_CardID;

		public MaterialPropertyBlock i_PropertyBlock;

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
	private struct _003CSetMaterialPropertyBlockForMeshRenderer_003Ed__72 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CMaster_SkillCardData i_Card;

		public MaterialPropertyBlock i_PropertyBlock;

		private UniTask<Texture>.Awaiter _003C_003Eu__1;

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
	private struct _003CSetUI_003Ed__60 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CardRenderTextureSpriteRenderer _003C_003E4__this;

		public CMaster_SkillCardData card;

		public CancellationToken cancel;

		private UniTask<Texture2D>.Awaiter _003C_003Eu__1;

		private CMaster_ModelData _003Cmodel_003E5__2;

		private UniTask.Awaiter _003C_003Eu__2;

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
	private struct _003CStart_003Ed__52 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CardRenderTextureSpriteRenderer _003C_003E4__this;

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
	private struct _003C_Render_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CardRenderTextureSpriteRenderer _003C_003E4__this;

		public int i_Count;

		public CancellationToken canceltoken;

		private CMaster_SkillCardData[] _003Ccards_003E5__2;

		private Stopwatch _003Csw_003E5__3;

		private int _003Ccount_003E5__4;

		private int _003Ci_003E5__5;

		private UniTask<bool>.Awaiter _003C_003Eu__1;

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

	public static readonly Vector2Int Size;

	[SerializeField]
	private Canvas m_CanvasDebug;

	[SerializeField]
	private RawImage m_RawImageDebug;

	[SerializeField]
	private Sprite[] m_ManaCostSprite;

	[SerializeField]
	private Sprite[] m_ManaChargeSprite;

	[SerializeField]
	private Sprite[] m_RankSprite;

	[SerializeField]
	private Camera m_Camera;

	[SerializeField]
	private TextMeshPro m_CardName;

	[SerializeField]
	private TextMeshPro m_Explains;

	[SerializeField]
	private GameObject m_AtkFrame;

	[SerializeField]
	private TextMeshPro m_AtkValue;

	[SerializeField]
	private GameObject m_DefFrame;

	[SerializeField]
	private TextMeshPro m_DefValue;

	[SerializeField]
	private MeshRenderer m_Illust;

	[SerializeField]
	private SpriteRenderer m_JobIcon;

	[SerializeField]
	private SpriteRenderer m_Rank;

	[SerializeField]
	private GameObject m_CostExist;

	[SerializeField]
	private SpriteRenderer[] m_CostIcon;

	[SerializeField]
	private GameObject m_CostFree;

	[SerializeField]
	private GameObject m_ChargeExist;

	[SerializeField]
	private SpriteRenderer[] m_ChargeIcon;

	[SerializeField]
	private GameObject m_ChargeNone;

	[SerializeField]
	private SpriteRenderer m_NameFrame;

	[SerializeField]
	private Rarity m_Rarity;

	[SerializeField]
	private ManaKind m_ManaKind;

	[SerializeField]
	private string m_Job;

	[SerializeField]
	private Texture2D[] m_EffectGradientTextures;

	[SerializeField]
	private Material m_RenderCardForUGUI;

	[SerializeField]
	private Texture2D m_LoadingTexture;

	[NonSerialized]
	private CardDiffParts[] m_DiffParts;

	public Dictionary<string, RenderTexture> m_GenerateTexture;

	private static int RenderTextureMax;

	private List<string> m_UsedHistory;

	private int m_ShowIndex;

	private RenderTexture m_CommonRenderBuffer;

	private MaterialPropertyBlock m_MaterialPropertyBlock;

	private UniTask m_Rendering;

	private UniTask? m_AdditionaRendering;

	private AsyncOperationHandle<Texture2D> m_LoadedTexture;

	private Texture2D m_DummyIllust;

	private uint m_NonAwaitCount;

	private static Dictionary<ManaKind, int> m_TmpChargeMana;

	private static Dictionary<ManaKind, int> m_TmpCostMana;

	private List<string> m_PreferredID;

	private Priority m_Priority;

	public Texture2D LoadingTexture => null;

	public static ManaKind ConvManaKind(string i_Name)
	{
		return ManaKind.Dignity;
	}

	public bool IsCompletedAll()
	{
		return false;
	}

	public bool IsCompleted(string i_Card)
	{
		return false;
	}

	public bool IsCompletedPlayerCard()
	{
		return false;
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__52))]
	private UniTask Start()
	{
		return default;
	}

	public void RenderStart()
	{
	}

	private void OnDestroy()
	{
	}

	public void ReleaseTexture()
	{
	}

	private void AddHistory(string i_Id)
	{
	}

	[AsyncStateMachine(typeof(_003CGetAsyncTexture_003Ed__57))]
	public static UniTask<Texture> GetAsyncTexture(string id, CancellationToken i_Cancel)
	{
		return default;
	}

	public static bool TryGetTexture(string id, out Texture color, out Texture mask)
	{
		color = null;
		mask = null;
		return false;
	}

	private void ReleaseIllust()
	{
	}

	[AsyncStateMachine(typeof(_003CSetUI_003Ed__60))]
	private UniTask SetUI(CMaster_SkillCardData card, CancellationToken cancel)
	{
		return default;
	}

	public static Texture2D GetEffectGradientTexture(ManaKind kind)
	{
		return null;
	}

	public static Texture2D GetEffectGradientTexture(string kind)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CGetCardMaterialForUGUIAsync_003Ed__63))]
	public static UniTask<Material> GetCardMaterialForUGUIAsync(string id, bool setRandomParam = true)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CGetCardMaterialForUGUIAsync_003Ed__64))]
	public static UniTask<Material> GetCardMaterialForUGUIAsync(CMaster_SkillCardData card, bool setRandomParam = true)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CGetCardMaterialForUGUIAsync_003Ed__65))]
	public static UniTask<Material> GetCardMaterialForUGUIAsync(string id, Material orgMaterial, bool setRandomParm = true)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CGetCardMaterialForUGUIAsync_003Ed__66))]
	public static UniTask<Material> GetCardMaterialForUGUIAsync(CMaster_SkillCardData card, Material orgMaterial, bool setRandomParm = true)
	{
		return default;
	}

	public static Material GetCardMaterialForUGUI(string id, bool setRandomParam = true)
	{
		return null;
	}

	public static Material GetCardMaterialForUGUI(CMaster_SkillCardData card, bool setRandomParam = true)
	{
		return null;
	}

	public static Material GetCardMaterialForUGUI(string id, Material orgMaterial, bool setRandomParm = true)
	{
		return null;
	}

	public static Material GetCardMaterialForUGUI(CMaster_SkillCardData card, Material orgMaterial, bool setRandomParm = true)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CSetMaterialPropertyBlockForMeshRenderer_003Ed__71))]
	public static UniTask SetMaterialPropertyBlockForMeshRenderer(string i_CardID, MaterialPropertyBlock i_PropertyBlock)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CSetMaterialPropertyBlockForMeshRenderer_003Ed__72))]
	public static UniTask SetMaterialPropertyBlockForMeshRenderer(CMaster_SkillCardData i_Card, MaterialPropertyBlock i_PropertyBlock)
	{
		return default;
	}

	public static void SetLoadingCardForMeshRenderer(MaterialPropertyBlock i_PropertyBlock)
	{
	}

	[AsyncStateMachine(typeof(_003CRenderAll_003Ed__75))]
	public UniTask RenderAll(CancellationToken canceltoken)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003C_Render_003Ed__76))]
	private UniTask _Render(int i_Count, CancellationToken canceltoken)
	{
		return default;
	}

	private void AdditionaRendering(CancellationToken i_Cancel)
	{
	}

	public bool IsRenderComplete()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CRender_003Ed__79))]
	private UniTask<bool> Render(CancellationToken canceltoken, CMaster_SkillCardData i_Data)
	{
		return default;
	}

	private void OnValidate()
	{
	}

	private void SetCardType()
	{
	}

	public void RemoveAt(string id)
	{
	}

	public static IOrderedEnumerable<KeyValuePair<ManaKind, int>> GetCostList(string id)
	{
		return null;
	}

	public static IOrderedEnumerable<KeyValuePair<ManaKind, int>> GetCostList(CMaster_SkillCardData card)
	{
		return null;
	}

	public static IOrderedEnumerable<KeyValuePair<ManaKind, int>> GetChargeList(string id)
	{
		return null;
	}

	public static IOrderedEnumerable<KeyValuePair<ManaKind, int>> GetChargeList(CMaster_SkillCardData card)
	{
		return null;
	}

	public static void SetRenderTextureMax(int i_Value)
	{
	}

	public static int GetRenderTextureMax()
	{
		return 0;
	}

	public void SetPriority(Priority i_Priority)
	{
	}

	public CMaster_SkillCardData[] GetRenderingPriority()
	{
		return null;
	}

	public static CardSymbol GetDisplayCardSymbol(CMaster_SkillCardData i_Card)
	{
		return default;
	}
}
