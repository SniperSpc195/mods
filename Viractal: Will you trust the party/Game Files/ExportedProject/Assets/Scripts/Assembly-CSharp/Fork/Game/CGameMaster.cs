using UnityEngine;

namespace Fork.Game
{
	public class CGameMaster : MonoBehaviour
	{
		private const int RenderWidth = 1024;

		private const int RenderHeight = 1024;

		[SerializeField]
		private Camera m_RenderCamera;

		private Transform m_SceneCamera;

		[SerializeField]
		private Renderer m_Renderer;

		[SerializeField]
		private Transform m_Eye;

		[SerializeField]
		private Vector3 m_EyeCenter;

		[SerializeField]
		private Transform m_EyePoint;

		[SerializeField]
		private float m_EyeVerticalAngleLimit;

		[SerializeField]
		private float m_EyeHorizontalAngleLimit;

		[SerializeField]
		private Vector2 m_EyeArea;

		[SerializeField]
		private Animator m_Animator;

		private RenderTexture m_RenderTexture;

		private MaterialPropertyBlock m_Props;

		private CMaster_GmFaceData m_Data;

		public static CGameMaster Instance { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public static CMaster_GmFaceData GetPlayData()
		{
			return null;
		}

		public static void SetCameraActivate(bool i_Switch)
		{
		}

		public static void PlayMotion(string i_ID)
		{
		}

		public static void PlayLipMotion()
		{
		}

		public static void StopLipMotion()
		{
		}

		public static void PlayOnetimeLipMotion()
		{
		}

		private void _PlayMotion(string i_ID)
		{
		}

		private void _PlayLipMotion()
		{
		}

		private void _StopLipMotion()
		{
		}

		private void _PlayOnetimeLipMotion()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public Transform GetPosterTransform()
		{
			return null;
		}
	}
}
