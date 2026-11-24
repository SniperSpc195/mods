using System;
using System.Collections.Generic;

[Serializable]
public class CParamPlayer : CParamDef
{
	public CParamInt mDp;

	public CParamInt mDrSkill;

	public CParamInt mDrItem;

	public CParamInt mDrTag;

	public CParamInt mDrGold;

	public CParamInt mAddMoveNum;

	public List<CMaster_ItemData> mItem;

	public List<CSkillCardData> mDeck;

	public List<CSkillCardData> mDeckHighPriority;

	public List<CSkillCardData> mTemporaryAdditionCard;

	public List<CSkillCardData> mDeckRemain;

	public List<CSkillCardData> mHandCards;

	public int mMaxHandCards;

	public CIngameCounter mIngameCounter;

	public int GetAddMove()
	{
		return 0;
	}

	public CParamPlayer(CMaster_CharJobData job)
	{
	}

	public void SetLevel(int lv, bool overWrite = false)
	{
	}

	public int GetDrSkill(int add = 0)
	{
		return 0;
	}

	public int GetDrItem(int add = 0)
	{
		return 0;
	}

	public int GetDrTag(int add = 0)
	{
		return 0;
	}

	public int GetDrGold(int add = 0)
	{
		return 0;
	}

	public string DrSkillToString(int add = 0)
	{
		return null;
	}

	public string DrItemToString(int add = 0)
	{
		return null;
	}

	public string DrTagToString(int add = 0)
	{
		return null;
	}

	public string DrGoldToString(int add = 0)
	{
		return null;
	}

	public static string DrToString(int n)
	{
		return null;
	}

	public int GetPossessionNum(string id)
	{
		return 0;
	}

	public int GetMaxItems()
	{
		return 0;
	}

	public List<CMaster_ItemData> GetPossessionItemEffect(string effect)
	{
		return null;
	}

	public bool IsDiscardItem()
	{
		return false;
	}

	public bool IsPossessionItem(string id)
	{
		return false;
	}

	public CMaster_ItemData AddItem(string id)
	{
		return null;
	}

	public CMaster_ItemData AddItem(CMaster_ItemData data)
	{
		return null;
	}

	public void InsertItem(List<string> list)
	{
	}

	public void InsertItem(string id)
	{
	}

	public int GetItemFree()
	{
		return 0;
	}

	public void RemoveItem(int n)
	{
	}

	public void RemoveItem(string id)
	{
	}

	private void InitializeDeck()
	{
	}

	public void RefillDeck()
	{
	}

	public void ShuffleDeck()
	{
	}

	public CSkillCardData DrawCard()
	{
		return null;
	}

	public void ReDrawCard()
	{
	}

	public void AddCardToHand(string i_ID, bool i_Disposable)
	{
	}

	public void ReturnHandCards()
	{
	}

	public void ResetBattleExclusion()
	{
	}

	public void ResetBattleExclusion(uint i_AvailabilityNum)
	{
	}

	public void DeleteExclusionCard()
	{
	}

	public int CountDeckMaster()
	{
		return 0;
	}

	private bool ContainDeck(CSkillCardData i_Data)
	{
		return false;
	}

	public int CountDeckRemain()
	{
		return 0;
	}

	public void AddDeck(CSkillCardData card, int insertIndex = -1)
	{
	}

	public void AddDeckHighPriority(CSkillCardData i_Card, bool i_Disposable)
	{
	}

	public void InsertDeckHighPriority(CSkillCardData i_Card, int i_Index, bool i_Disposable)
	{
	}

	public void AddDeckTemporary(CSkillCardData card, bool i_Shuffle)
	{
	}

	public void ClearDeckTemporary()
	{
	}

	public void RemoveTemporaryAdditionCard(CSkillCardData i_Data)
	{
	}

	public void RemoveCardDeckIndex(int i)
	{
	}

	public void RemoveCards(string id, int num)
	{
	}

	public void GetUsedCard(ref List<CSkillCardData> i_UsedCard, bool i_AddExclusion)
	{
	}

	public void AbilityDeckEmpty(bool i_CheckEmpty = true)
	{
	}

	public CSkillCardData UpgradeCard(int i_Index)
	{
		return null;
	}

	public void SortHandCards(CConfigData.SortHandCard i_SortType)
	{
	}

	private int CompareValue(CSkillCardData a, CSkillCardData b)
	{
		return 0;
	}

	public List<int> GetUpgradeCardIndex()
	{
		return null;
	}

	public int CountInsectTag(CSkillCardData i_ExceptCard)
	{
		return 0;
	}

	public static bool CheckSaveData(string savefile, int index, JsonNode json)
	{
		return false;
	}

	public void SaveParam(Dictionary<string, object> save, bool id = false, bool name = false)
	{
	}

	public void SaveItem(Dictionary<string, object> save)
	{
	}

	public void SaveAbility(Dictionary<string, object> save)
	{
	}

	public void SaveCards(Dictionary<string, object> save)
	{
	}

	public void SaveIngameCounter(Dictionary<string, object> save)
	{
	}

	public void LoadParam(JsonNode json)
	{
	}

	public void LoadLv(JsonNode json)
	{
	}

	public void LoadDp(JsonNode json)
	{
	}

	public void LoadDroprank(JsonNode json)
	{
	}

	public void LoadItem(JsonNode json)
	{
	}

	public void LoadAbility(JsonNode json)
	{
	}

	public void LoadCards(JsonNode json)
	{
	}

	public void LoadIngameCounter(JsonNode json)
	{
	}

	public void AddGold(int i_AddGold, bool i_IsBonus)
	{
	}

	public void AddGold(int i_AddGold, bool i_IsBonus, out int o_Bonus)
	{
		o_Bonus = default;
	}

	public override string GetModelID()
	{
		return null;
	}
}
