using UnityEngine;

namespace Fork.Game
{
	public class DropCard : MonoBehaviour
	{
		private Vector3 m_InitialSpeed;

		private Vector3 m_Speed;

		private Vector3 m_InitialPosition;

		private Vector3 m_Accel;

		private Vector3 m_Position;

		private double m_Time;

		private MeshRenderer m_Mesh;

		private Vector3 m_InitialLocalPosition;

		public static float GravityScaler;

		public static float SpeedScaler;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
