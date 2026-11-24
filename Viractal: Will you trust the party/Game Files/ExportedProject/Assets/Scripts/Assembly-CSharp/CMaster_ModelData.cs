using System;

[Serializable]
public class CMaster_ModelData : IMasterData
{
	public enum Illust
	{
		CardJobIcon = 0,
		StatusFace = 1
	}

	public string id;

	public float scale;

	public string path;

	public bool dead;

	public string balloon_node;

	public float balloon_ofsx;

	public float balloon_ofsy;

	public float balloon_ofsz;

	public string ID => null;

	public string GetPrefabName()
	{
		return null;
	}

	public string GetFileNameWithoutDirectory()
	{
		return null;
	}

	public string GetIllustPath(Illust illust)
	{
		return null;
	}

	public string GetIllustName(Illust illust)
	{
		return null;
	}
}
