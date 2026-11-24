using Fork.Game;
using UnityEngine;
using UnityEngine.Events;

namespace Fork.ModelButtons
{
	[AddComponentMenu("Fork/ModelButton")]
	public class CUIModelButton : MonoBehaviour
	{
		public static readonly Color m_SelectEdgeColor;

		public static readonly Color m_DeselectEdgeColor;

		[SerializeField]
		public Collider m_Collider;

		[SerializeField]
		public Vector3 m_Pivot;

		[SerializeField]
		public Vector3 m_Pivot2D;

		[SerializeField]
		public MeshRenderer m_HighlightModel;

		public UnityEvent onClick;

		public UnityEvent<CUITooltip> onOpenTooltip;

		private Coroutine m_TooltipCoroutine;

		private MaterialPropertyBlock m_Property;

		private Camera m_Camera;

		private bool m_Highlighted;

		private CInOutPattern m_TooltipAnimator;

		public float? m_SpecificHighlightWidth { get; set; }

		public TooltipType m_TooltipType { get; set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Start()
		{
		}

		public void SetHighlightModel(MeshRenderer i_MeshRenderer)
		{
		}

		public virtual void Select(Camera i_Camera, bool i_EnableHighlight = false)
		{
		}

		public virtual void Deselect()
		{
		}

		protected virtual void Update()
		{
		}

		private void HideTooltip()
		{
		}

		public void ShowTooltip(Camera i_Camera)
		{
		}

		public Vector3 CalcTooltipPoint(Camera i_Camera)
		{
			return default;
		}

		public Vector3 CalcFingerCursorPoint(Camera i_Camera)
		{
			return default;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
