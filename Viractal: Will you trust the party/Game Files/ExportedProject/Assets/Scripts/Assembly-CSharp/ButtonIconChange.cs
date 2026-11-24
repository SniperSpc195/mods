using UnityEngine;
using UnityEngine.InputSystem;

public class ButtonIconChange : MonoBehaviour
{
	private enum STAT
	{
		Switch = 0,
		PC = 1
	}

	[SerializeField]
	[ReadOnly]
	private Sprite mOriginal;

	[SerializeField]
	[ReadOnly]
	private GamePad.TYPE mType;

	[SerializeField]
	[ReadOnly]
	private bool mSwap;

	[SerializeField]
	[ReadOnly]
	private STAT mStat;

	public void Initialize(GameController.PADNUM padNum = GameController.PADNUM.PAD0)
	{
	}

	public void Change(GameController.PADNUM padNum = GameController.PADNUM.PAD0)
	{
	}

	public static Key GetPadToKeyboard(uint pad)
	{
		return Key.None;
	}

	public static Sprite GetIconKeyboard(uint pad)
	{
		return null;
	}

	public static string GetStringKeyboard(uint pad)
	{
		return null;
	}
}
