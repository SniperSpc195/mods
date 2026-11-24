using Cysharp.Text;
using Fork.Game;
using TMPro;
using UnityEngine;

namespace Fork.Battle
{
	public class CFlyText : MonoBehaviour
	{
		private enum Transition
		{
			Countup = 0,
			FadeOut = 1,
			End = 2
		}

		public enum Mode
		{
			Number = 0,
			Text = 1
		}

		private static Vector3 height;

		[SerializeField]
		private Animator m_Animator;

		[SerializeField]
		private TMP_Text m_Text;

		[SerializeField]
		private bool m_StatusEffect;

		[SerializeField]
		private CFontType m_FontType;

		private Vector3 m_AttachWorldOffset;

		private Vector2 m_AttachScreenOffset;

		private bool m_EnableFollow;

		public const int CountupTime = 12;

		private const int TextIdleTime = 50;

		private float m_CountupTimeCurrent;

		private uint m_CountupValue;

		public const int WaitDamage = 20;

		public const int WaitHeal = 35;

		public const int WaitTimeText = 30;

		private Camera m_Camera;

		private Transition m_Transition;

		private uint m_CountupGoal;

		private Mode m_Mode;

		private float m_GameSpeed;

		public Transform m_AttachTransform { get; private set; }

		public CInOutPattern m_InOut { get; private set; }

		public CCharDef m_Character { get; private set; }

		public CMaster_SkillConditionData m_Condition { get; private set; }

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateTextMode()
		{
		}

		private void UpdateNumberMode()
		{
		}

		public void Initialize()
		{
		}

		public void SetMode(Mode i_Mode)
		{
		}

		public bool IsCountupEnd()
		{
			return false;
		}

		public bool IsCountupOvertime(int i_Frame)
		{
			return false;
		}

		public bool IsEnd()
		{
			return false;
		}

		public void SetColor(Color i_Color)
		{
		}

		public void SetNumber(uint i_Number)
		{
		}

		public void AddNumber(uint i_Number)
		{
		}

		public void SetText(string i_Text)
		{
		}

		public void SetText(Utf16ValueStringBuilder i_Text)
		{
		}

		public void SetPosition(Vector3 i_Position)
		{
		}

		public void SetAttachTransform(Transform i_Transform, Vector3 i_WorldOffset = default(Vector3), Vector2 i_ScreenOffset = default(Vector2), bool i_Enable = false)
		{
		}

		private Vector3 GetOverlayPos(Vector3 i_WorldOffset = default(Vector3), Vector2 i_ScreenOffset = default(Vector2))
		{
			return default;
		}

		public void SetCharacter(CCharDef i_Character)
		{
		}

		public void SetCondition(CMaster_SkillConditionData i_Condition)
		{
		}
	}
}
