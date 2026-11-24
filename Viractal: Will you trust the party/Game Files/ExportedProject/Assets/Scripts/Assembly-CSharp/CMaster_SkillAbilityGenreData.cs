using System;
using UnityEngine;

[Serializable]
public class CMaster_SkillAbilityGenreData : IMasterData
{
	public string id;

	public string base_color;

	public string frame_color;

	private Color? _BaseColor;

	private Color? _FrameColor;

	public string ID => null;

	public Color BaseColor => default;

	public Color FrameColor => default;
}
