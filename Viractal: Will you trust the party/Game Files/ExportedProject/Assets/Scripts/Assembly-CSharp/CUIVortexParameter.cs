using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[AddComponentMenu("UI/VortexParameter")]
[RequireComponent(typeof(Graphic))]
[ExecuteAlways]
public class CUIVortexParameter : UIBehaviour, IMaterialModifier
{
	[SerializeField]
	private float m_VortexPower;

	private Material m_Material;

	private Graphic m_Graphic;

	private static readonly int m_ParameterKey;

	public float VortexPower
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Material GetModifiedMaterial(Material i_Material)
	{
		return null;
	}

	protected override void OnDidApplyAnimationProperties()
	{
	}

	protected override void OnDisable()
	{
	}

	private void SetMaterialDirty()
	{
	}
}
