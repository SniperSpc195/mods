using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Fork.Game
{
	public class CStopButton : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler
	{
		[CompilerGenerated]
		private Action<PointerEventData> m_mPointerEnterCallback;

		[CompilerGenerated]
		private Action<PointerEventData> m_mPointerExitCallback;

		[CompilerGenerated]
		private Action<PointerEventData> m_mPointerClickCallback;

		public event Action<PointerEventData> mPointerEnterCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PointerEventData> mPointerExitCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<PointerEventData> mPointerClickCallback
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void OnPointerEnter(PointerEventData pointerEventData)
		{
		}

		public void OnPointerExit(PointerEventData pointerEventData)
		{
		}

		public void OnPointerClick(PointerEventData pointerEventData)
		{
		}

		private void Start()
		{
		}

		private void OnButton(PointerEventData pointerEventData)
		{
		}

		private void OffButton(PointerEventData pointerEventData)
		{
		}

		private void ClickButton(PointerEventData pinterEventData)
		{
		}
	}
}
