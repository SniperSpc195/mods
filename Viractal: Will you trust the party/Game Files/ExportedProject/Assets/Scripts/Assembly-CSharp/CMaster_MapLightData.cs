using System;

[Serializable]
public class CMaster_MapLightData : IMasterData
{
	public string id;

	public string kind;

	public string stage;

	public string ambient_light;

	public string light;

	public string ID => null;

	public string GetScenePath()
	{
		return null;
	}
}
