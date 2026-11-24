using System;
using System.Collections.Generic;
using UnityEngine.Events;

[Serializable]
public class CConfigData
{
	public enum ButtonAssign
	{
		AB = 0,
		BA = 1
	}

	public enum GraphicsQualitySettings
	{
		Performant = 0,
		Balanced = 1,
		HighFidelity = 2
	}

	public enum RenderScale
	{
		_50 = 0,
		_75 = 1,
		_100 = 2
	}

	public enum Switch
	{
		Off = 0,
		On = 1
	}

	public enum SortHandCard
	{
		Attack = 0,
		Obtain = 1
	}

	public int m_MasterVolume;

	public int m_BGMVolume;

	public int m_SEVolume;

	public Switch m_SoundXR;

	public ButtonAssign m_ButtonAssign;

	public GraphicsQualitySettings m_QualitySettings_PC;

	public RenderScale m_RenderScale_PC;

	public Switch m_BlurEnable_PC;

	public Switch m_FullscreenMode_PC;

	public Switch m_WindowsizeRestoreMode_PC;

	public SortHandCard m_SortHandCards;

	public Switch m_GMMessageCut;

	public Switch m_ItemInitialActivePlayer;

	private static readonly float[] _RenderScales;

	private static readonly string[] _QualitySettings;

	private static string[] _SystemQualitySettingsNames;

	private static string[] SystemQualitySettingsNames => null;

	public UnityEvent<ButtonAssign> OnButtonAssignChanged { get; private set; }

	public UnityEvent<bool> OnBlurEnableChanged { get; private set; }

	public Dictionary<string, object> Save()
	{
		return null;
	}

	public void Load(JsonNode i_Data)
	{
	}

	public void Apply(bool i_ChangeWindowSizeWithRestoreMode = false)
	{
	}

	public void CopyFrom(CConfigData i_Source)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public bool Equals(CConfigData right)
	{
		return false;
	}

	public List<CSaveData.WRITEDATA> CreateSaveData()
	{
		return null;
	}
}
