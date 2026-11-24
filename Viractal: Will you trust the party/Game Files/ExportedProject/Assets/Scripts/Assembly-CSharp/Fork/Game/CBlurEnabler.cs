using System.Collections.Generic;
using UnityEngine;

namespace Fork.Game
{
	public class CBlurEnabler : MonoBehaviour
	{
		[SerializeField]
		private string[] m_RendererNames;

		private HashSet<string> m_RendererNamesRuntime;

		private List<Renderer> m_RendererList;

		public bool m_IsActive;

		private bool m_IsAwaken;

		private bool m_ActivateOnStart;

		private int m_RetryOnce;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void ChangeRendererList(IEnumerable<string> i_RendererNames)
		{
		}

		public void Activate()
		{
		}

		public void Deactivate()
		{
		}
	}
}
