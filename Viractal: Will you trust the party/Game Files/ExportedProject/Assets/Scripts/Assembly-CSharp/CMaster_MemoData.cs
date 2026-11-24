using System;

[Serializable]
public class CMaster_MemoData : IMasterData
{
	public enum UNLOCK_IF
	{
		None = 0,
		StageClear = 1,
		JobClear = 2,
		GFLAG = 3,
		GWORK = 4,
		GamePlay = 5
	}

	public string id;

	public int priority;

	public string unlock_if;

	public string value_1;

	public int value_2;

	public string tutorial_id;

	private UNLOCK_IF mUnlockIF;

	public string ID => null;

	public int GetNumID()
	{
		return 0;
	}

	public UNLOCK_IF GetUnlockIf()
	{
		return UNLOCK_IF.None;
	}

	public bool IsAppearance(CMain _main)
	{
		return false;
	}
}
