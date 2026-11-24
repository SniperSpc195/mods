using UnityEngine;
using UnityEngine.Rendering;

[AddComponentMenu("Rendering/ShadowDistanceModifier")]
[RequireComponent(typeof(Camera))]
public class CShadowDistanceModifier : MonoBehaviour
{
	[SerializeField]
	public float m_TargetShadowDitance;

	private float? m_BackupShadowDistance;

	private Camera _camera;

	private Camera m_Camera => null;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void ModifyShadowDistance(ScriptableRenderContext i_Context, Camera i_Camera)
	{
	}

	private void RevertShadowDistance(ScriptableRenderContext i_Context, Camera i_Camera)
	{
	}
}
