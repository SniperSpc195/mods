using System;
using UnityEngine;

namespace Fork.Game
{
	[AddComponentMenu("Fork/CharacterStatus/GoldColumn")]
	public class CUIModelGoldColumn : MonoBehaviour
	{
		[SerializeField]
		private Renderer m_Reel;

		private MaterialPropertyBlock m_Property;

		private float m_ValueBackup;

		private float m_Value;

		private Vector2 m_Velocity;

		private void Awake()
		{
		}

		public void SetValue(float i_Value)
		{
		}

		private void Update()
		{
		}

		public void SetMaterialProperties(Action<MaterialPropertyBlock> i_Setter)
		{
		}
	}
}
