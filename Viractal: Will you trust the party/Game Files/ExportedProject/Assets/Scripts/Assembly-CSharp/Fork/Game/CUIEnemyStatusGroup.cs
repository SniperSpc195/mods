using System.Collections.Generic;
using Fork.ModelButtons;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/EnemyStatus/EnemyStatusGroup")]
	public class CUIEnemyStatusGroup : MonoBehaviour
	{
		private struct EnemyPosition
		{
			public CBattleEnemy enemy;

			public int uiPosition;
		}

		[SerializeField]
		private CUIEnemyStatus[] m_EnemyStatusList;

		[SerializeField]
		private Animator m_Animator;

		[SerializeField]
		private CUIModelButtonGroup m_ButtonGroup;

		[SerializeField]
		private CUIFingerCursor m_FingerCursor;

		[SerializeField]
		private Camera m_CameraTransform;

		private List<EnemyPosition> m_Enemies;

		private bool m_BossMode;

		private ResetTransform[] m_ResetTransforms;

		public CInOutPattern m_InOut { get; private set; }

		private ResetTransform[] ResetTransforms => null;

		private void Awake()
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}

		public bool IsHide()
		{
			return false;
		}

		private void Start()
		{
		}

		public void SetParent(CUICharacterStatusGroup i_Parent)
		{
		}

		public void SetEnemies(List<CBattleEnemy> i_Enemies)
		{
		}

		public void OnValueChanged(float i_Time = 0f)
		{
		}

		public void OnValueChanged(CCharDef i_Character, float i_Time = 0f)
		{
		}

		public CUIEnemyStatus GetEnemyStatus(CCharDef i_Character)
		{
			return null;
		}

		public void ActivateFingerCursor(CUIEnemyStatus i_EnemyStatus)
		{
		}

		public void ActivateFingerCursor(Vector3 i_Point)
		{
		}

		public void HighlightEnemyStatus(List<CBattleEnemy> i_Enemies)
		{
		}
	}
}
