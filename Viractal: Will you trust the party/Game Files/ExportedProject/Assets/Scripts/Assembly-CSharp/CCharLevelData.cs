using System.Collections.Generic;

public class CCharLevelData
{
	private static Dictionary<string, CCharLevelData> m_Cache;

	public string mJobID;

	public int mLv;

	public int mExp;

	public int mHp;

	public int mAt;

	public int mDf;

	public int mSp;

	public static CCharLevelData GetData(string job, int lv)
	{
		return null;
	}
}
