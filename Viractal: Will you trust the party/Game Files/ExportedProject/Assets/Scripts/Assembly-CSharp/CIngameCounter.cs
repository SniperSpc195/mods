using System;
using System.Collections.Generic;

[Serializable]
public class CIngameCounter
{
	public CParamInt m_Kill;

	public CParamInt m_DamageTaken;

	public CParamInt m_DamageDealt;

	public CParamInt m_Dead;

	public CParamInt m_Block;

	public CParamInt m_Condition;

	public CParamInt m_Movement;

	public CParamInt m_Dice6;

	public CParamInt m_EncountEnemy;

	public CParamInt m_EncountCardSpring;

	public CParamInt m_EncountMysteriousRuins;

	public CParamInt m_EncountTreasure;

	public CParamInt m_Gold;

	public CParamInt m_Whispers;

	public void Save(Dictionary<string, object> save)
	{
	}

	public void Load(JsonNode json)
	{
	}
}
