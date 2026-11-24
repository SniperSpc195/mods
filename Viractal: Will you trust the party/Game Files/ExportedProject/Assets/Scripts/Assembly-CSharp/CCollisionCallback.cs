using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CCollisionCallback : MonoBehaviour
{
	private struct HitEffect
	{
		public UnityAction<Vector3, CSkill> func;

		public CSkill skill;
	}

	public ParticleSystem m_Particle;

	private HitEffect m_HitEffect;

	private List<ParticleSystem.Particle> m_TriggerEnter;

	public void AddHitEvent(UnityAction<Vector3, CSkill> enter, CSkill skill)
	{
	}

	private void OnParticleTrigger()
	{
	}
}
