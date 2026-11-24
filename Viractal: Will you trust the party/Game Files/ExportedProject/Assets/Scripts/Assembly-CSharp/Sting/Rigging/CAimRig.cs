using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace Sting.Rigging
{
	[AddComponentMenu("Rigging/AimRig")]
	[RequireComponent(typeof(Rig))]
	public class CAimRig : CRigControlBase
	{
		[SerializeField]
		private Transform m_AimTarget;

		[SerializeField]
		private Vector3 m_AimingOffset;

		private Transform m_ActiveTarget;

		public void SetTarget(Transform i_Target, Vector3 i_Offset = default(Vector3))
		{
		}

		private void Update()
		{
		}
	}
}
