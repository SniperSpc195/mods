using UnityEngine;

namespace Ffft
{
	[ExecuteAlways]
	public class ParticleSystemContinuousSignal : MonoBehaviour
	{
		[SerializeField]
		private ParticleSystem m_Ps;

		[SerializeField]
		public float m_SignalsPerSecond;

		[SerializeField]
		private int m_SubEmitterIndex;

		private float m_StartTime;

		private float interval => 0f;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}
	}
}
