using TMPro;
using UnityEngine;

public class CDebugMenu : MonoBehaviour
{
	public enum MENU
	{
		EventTest = 0,
		GamemasterAnime = 1,
		PlayerPosition = 2,
		ObjectPosition = 3,
		AddEnemy = 4,
		Battle = 5,
		BattleRush = 6,
		BossBattle = 7,
		DevilsWhispers = 8,
		フリーカメラ = 9,
		ダイスの出目 = 10,
		Ladder = 11,
		フラグ設定 = 12,
		ワーク設定 = 13,
		DebugSw = 14,
		SoundTest = 15,
		EffectTest = 16,
		SceneChange = 17,
		カードリスト = 18,
		カードリスト_レンダリング実行 = 19,
		カードリスト_レンダリング済み = 20,
		カードテクスチャ解放 = 21,
		カードをデッキに追加 = 22,
		カードを手札に追加 = 23,
		CardSelector = 24,
		CardObtain = 25,
		BattleResult = 26,
		GameObjectActivator = 27,
		OnlineOwnRoom = 28,
		DeleteAbility = 29,
		Quality = 30,
		DynamicResolution = 31,
		StaticResolutionScale = 32,
		BattleWin = 33,
		BattleLose = 34,
		BattleEscape = 35,
		BattleInvinciblePlayer = 36,
		BattleInvincibleEnemy = 37,
		WillCostFree = 38,
		DpCostFree = 39,
		ItemFree = 40,
		DisplayTimeline = 41,
		TimelineType = 42,
		決定ボタンで行動開始 = 43,
		強制ドロップ = 44,
		宝箱1個目FilterKind = 45,
		宝箱1個目FilterRarity = 46,
		宝箱2個目FilterKind = 47,
		宝箱2個目FilterRarity = 48,
		宝箱3個目FilterKind = 49,
		宝箱3個目FilterRarity = 50,
		状態異常付与 = 51,
		ブロック解除 = 52,
		ポップアップテスト1 = 53,
		ポップアップテスト2 = 54,
		ポップアップテスト3 = 55,
		ボスバトル開始演出 = 56,
		ボス戦闘不能演出 = 57,
		ゲームオーバーバホコ = 58,
		ターン開始待ち時間入力_味から味 = 59,
		ターン開始待ち時間入力_味から敵 = 60,
		ターン開始待ち時間入力_敵から敵 = 61,
		ターン開始待ち時間入力_敵から味 = 62,
		ターン開始待ち時間入力_味から敵_移動 = 63,
		ターン開始待ち時間入力_敵から味_移動 = 64,
		BtlCameraReset = 65,
		BtlCamPitchUnlimited = 66,
		BtlCamYawUnlimited = 67,
		ClearTutorialSeenFlags = 68,
		ReloadActionScript = 69,
		AddSoulPoint = 70,
		ソウルポイント入力 = 71,
		総プレイ時間入力 = 72,
		各ステージプレイ回数入力 = 73,
		各ステージクリア回数入力 = 74,
		各ステージ全滅回数入力 = 75,
		各ジョブプレイ回数入力 = 76,
		各ジョブクリア回数入力 = 77,
		各ジョブ全滅回数入力 = 78,
		メモ閲覧済 = 79,
		メモ出現 = 80,
		AudioListenerDistance = 81,
		CardDelete = 82,
		Staffroll = 83,
		FlagSetCharacter = 84,
		FlagSetItem = 85,
		FlagSetCard = 86,
		FlagSetEventObject = 87,
		FlagSetStage = 88,
		キャラクターとステージ修復 = 89,
		所持データ修復 = 90,
		所持データログ出力 = 91,
		実績 = 92,
		統計データと実績のリセット = 93,
		移動停止後のイベント = 94,
		カメラのFarClip = 95,
		カードレンダリング枚数変更 = 96,
		棚全解放 = 97,
		SoundCrossFadeTest = 98,
		UnloadUnusedAssets = 99
	}

	public struct MENU_DATA
	{
		public MENU mMenu;

		public string mText;

		public MENU_DATA(MENU menu)
		{
			mMenu = MENU.EventTest;
			mText = null;
		}

		public MENU_DATA(MENU menu, string text)
		{
			mMenu = MENU.EventTest;
			mText = null;
		}
	}

	private enum MODE
	{
		None = 0,
		End = 1,
		TopSelect = 2,
		SubMenu = 3,
		フリーカメラ = 4,
		フラグ設定 = 5,
		ワーク設定 = 6,
		Download = 7,
		Battle_Start = 8,
		Battle_Wait = 9,
		Battle_EndWait = 10,
		BattleCamera_Wait = 11,
		BossBattle_Event = 12,
		BossBattle_Start = 13,
		BossBattle_Wait = 14,
		CardList_Start = 15,
		CardList_Wait = 16,
		CardSelector_Start = 17,
		CardSelector_Wait = 18,
		ObtainCard_Start = 19,
		ObtainCard_Wait = 20,
		GrantCondition_SelectTarget = 21,
		GrantCondition_DeleteStart = 22,
		GrantCondition_DeleteWait = 23,
		ReleaseBlock_SelectTarget = 24,
		BattleResult_Start = 25,
		BattleResult_Wait = 26,
		GameObjectActivator_Start = 27,
		GameObjectActivator_Wait = 28,
		ActionView = 29,
		DeleteAbility = 30,
		DeleteAbility_Wait = 31,
		OfflineDialog_Wait = 32,
		AudioListenerDistance = 33,
		CardDelete_Wait = 34,
		Staffroll_Wait = 35,
		OnFlagCharacter = 36,
		OffFlagCharacter = 37,
		OnFlagItem = 38,
		OffFlagItem = 39,
		OnFlagCard = 40,
		OffFlagCard = 41,
		OnFlagEventObject = 42,
		OffFlagEventObject = 43,
		OnFlagStage = 44,
		OffFlagStage = 45,
		SoundCrossFadeTest_Start = 46,
		SoundCrossFadeTest_Wait = 47,
		SaveSystemData_Start = 48,
		SaveSystemData_Wait = 49
	}

	private MENU_DATA[] mTopMenuList;

	[SerializeField]
	private CScrollMenu mTopMenu;

	[SerializeField]
	private CScrollMenu mSubMenu;

	[SerializeField]
	private CUIGenericInputText mInputNum;

	[SerializeField]
	private CUIGenericInputText mInputString;

	[SerializeField]
	private DebugSlider mDebugSlider;

	[SerializeField]
	private TextMeshProUGUI mSubMenuLabel;

	private CDebugBattleGroupDetailWindow mBattleGroupDetailWindow;

	private CDebugBattleGroupTabWindow mBattleGroupTabWindow;

	private GameObject mGameObjectSubMenu;

	private bool mExistTopMenu;

	private bool IsField;

	private bool IsBattle;

	private Vector2 mPosSubMenu;

	private MODE mMode;

	private MENU mSelectMenu;

	public bool IsBattleControl { get; set; }

	public CDebugEventTest GetDebugEventTest()
	{
		return null;
	}

	private void Awake()
	{
	}

	public void SetMenu(MENU_DATA[] list, Vector2 position, bool reqSe = true)
	{
	}

	public void Go()
	{
	}

	public void GoSubMenu(MENU menu, Vector2 v)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public static bool GetPadOk(bool isControl, CScrollMenu menu, GamePad pad)
	{
		return false;
	}
}
