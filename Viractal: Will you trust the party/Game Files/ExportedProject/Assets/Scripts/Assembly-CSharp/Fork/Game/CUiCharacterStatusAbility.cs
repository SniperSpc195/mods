using Fork.ModelButtons;
using UnityEngine;

namespace Fork.Game
{
	public class CUiCharacterStatusAbility : MonoBehaviour
	{
		private static readonly int EdgeColor;

		private static readonly int MultiColor;

		private static readonly int LayerMaskMap;

		private static readonly int NormalMap;

		private CMaster_SkillAbilityData m_Data;

		private MaterialPropertyBlock m_Property;

		private Renderer m_Renderer;

		private Texture2D m_ColorTexture;

		private Texture2D m_NormalTexture;

		private Color m_FrameColor;

		private Color m_BaseColor;

		private CUICharacterStatus m_Status;

		public float? m_SpecificTooltipBallonPoint;

		public string m_ID => null;

		public CUIModelButton Button { get; private set; }

		public CInOutPattern m_InOut { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetCharacterStatus(CUICharacterStatus i_Status)
		{
		}

		public void UpdateValue(CMaster_SkillAbilityData i_Ability, Texture2D i_ColorTexture, Texture2D i_NormalTexture, Color i_BaseColor, Color i_FrameColor)
		{
		}

		private void Update()
		{
		}

		public static void SetupTooltipExternal(CUITooltip i_Tooltip, CMaster_SkillAbilityData i_Data)
		{
		}

		private void SetupTooltip(CUITooltip i_Tooltip)
		{
		}

		public void PlayActivateEffect()
		{
		}
	}
}
