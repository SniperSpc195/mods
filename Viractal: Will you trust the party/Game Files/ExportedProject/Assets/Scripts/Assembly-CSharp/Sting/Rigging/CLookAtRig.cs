using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace Sting.Rigging
{
	[AddComponentMenu("Rigging/LookAtRig")]
	[RequireComponent(typeof(Rig))]
	public class CLookAtRig : CRigControlBase
	{
		private static readonly Vector3 InvalidPosition;

		[SerializeField]
		public Transform m_LookAtTarget;

		[SerializeField]
		private float m_LimitAngle;

		[SerializeField]
		public float m_EyeLevel;

		public float m_LerpParam;

		private float m_LimitAngleCosign;

		private Transform m_ActiveTarget;

		private Vector3 m_TargetOffset;

		private Vector3 m_CurrentTargetPosition;

		private Transform m_Head;

		private MultiAimConstraint[] m_Constraints;

		public float m_WeightScaler { get; set; }

		protected override void Awake()
		{
		}

		public void SetHeadLimit(float i_AngleDegree)
		{
		}

		public void SetTarget(Transform i_Target, Vector3 i_Offset = default(Vector3))
		{
		}

		public Transform GetTarget()
		{
			return null;
		}

		private void Update()
		{
		}

		private void UpdateWeight()
		{
		}

		private void SetLookAtTarget()
		{
		}

		private void OnValidate()
		{
		}
	}
}
