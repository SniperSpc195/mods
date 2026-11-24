using UnityEngine;

namespace Fork.Game
{
	public class CGameStartCamera : MonoBehaviour
	{
		private static CGameStartCamera Instance;

		[SerializeField]
		private GameObject m_BoxViewCamera;

		[SerializeField]
		private GameObject m_MoveCamera;

		[SerializeField]
		private Animator m_MoveAnimator;

		private Animator m_FloorAnimator;

		private double m_BoxViewCameraStart;

		public static void StartBoxView()
		{
		}

		public static void StartMoveCamera()
		{
		}

		public static bool IsMoveCamera()
		{
			return false;
		}

		public static bool IsMoving()
		{
			return false;
		}

		public static bool IsBoxViewMoving()
		{
			return false;
		}

		public static void Stop()
		{
		}

		public static void SetFloorAnimator(Animator i_Animator)
		{
		}

		public static void Reset()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
