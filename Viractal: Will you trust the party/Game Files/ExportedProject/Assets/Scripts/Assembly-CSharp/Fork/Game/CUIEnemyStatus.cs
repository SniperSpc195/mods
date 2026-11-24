using Fork.ModelButtons;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/EnemyStatus/EnemyStatus")]
	public class CUIEnemyStatus : MonoBehaviour
	{
		private static readonly string SEKnock;

		[SerializeField]
		private CUIModelHPBar m_HpBar;

		[SerializeField]
		private CUICharacterStatusFace m_Face;

		[SerializeField]
		private CUICharacterStatusConditionHolder m_ConditionHolder;

		[SerializeField]
		private Animator m_Animator;

		[SerializeField]
		private CRigidbodyKnocker m_RigidbodyKnocker;

		private CUICharacterStatusGroup m_CharacterStatusGroup;

		private CUIEnemyStatusGroup m_EnemyStatusGroup;

		private CParamEnemy m_BackupParameter;

		private CBattleEnemy m_Enemy;

		private int m_BackupBlock;

		[SerializeField]
		private Rigidbody m_Rigidbody;

		[SerializeField]
		public CUIModelButton m_Button;

		[SerializeField]
		private GameObject m_HighlightNode;

		public float ForceImpluse;

		public float TorqueImpluse;

		private CRigidbodyKnockerHandler m_RigidbodyFixer;

		private int m_UserKnockTime;

		public CParamEnemy m_Parameter { get; private set; }

		public CInOutPattern m_InOut { get; private set; }

		private void Awake()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public void SetParent(CUICharacterStatusGroup i_Chr, CUIEnemyStatusGroup i_Ene)
		{
		}

		public void OnValueChanged(float i_Time = 0f)
		{
		}

		public void InitParameter(CBattleEnemy i_Enemy)
		{
		}

		private void SetValuesImmediatePart()
		{
		}

		private void SetValuesImmediate()
		{
		}

		private void SetValuesAnimate(float i_Time)
		{
		}

		public void SetHighlight(bool i_Switch)
		{
		}

		public void SetForce()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
