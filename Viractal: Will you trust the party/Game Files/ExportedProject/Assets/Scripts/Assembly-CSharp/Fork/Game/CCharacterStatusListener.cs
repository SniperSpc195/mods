using UnityEngine;

namespace Fork.Game
{
	public class CCharacterStatusListener : MonoBehaviour
	{
		private Custom3DListener nativeListener;

		public float m_ModelSize;

		public float m_RealSize;

		private Vector3 lastPosition;

		private bool _isActive;

		public bool isActive
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Custom3DListener GetListener()
		{
			return null;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdatePosition()
		{
		}
	}
}
