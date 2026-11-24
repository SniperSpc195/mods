using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Fork.Game
{
	[RequireComponent(typeof(Graphic))]
	public class CUISliderMouseOp : UIBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IPointerClickHandler
	{
		private RectTransform m_RectTransform;

		public UnityEvent<Vector2> onValueChanged;

		private bool m_Ended;

		private Vector2? m_NormalizedPosition;

		private Graphic m_RaycastTarget;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnPointerClick(PointerEventData i_EventData)
		{
		}

		public void OnBeginDrag(PointerEventData i_EventData)
		{
		}

		public void OnDrag(PointerEventData i_EventData)
		{
		}

		public void Cancel()
		{
		}

		private void SetSlider(Vector2 i_MousePosition)
		{
		}
	}
}
