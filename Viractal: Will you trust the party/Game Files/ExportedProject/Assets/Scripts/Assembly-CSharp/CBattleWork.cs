public static class CBattleWork
{
	public enum BtlTimelineType
	{
		Colckwise = 0,
		CounterColckwise = 1,
		Speed = 2
	}

	public static bool m_IsUsedMoveAction;

	public static BtlTimelineType m_BtlTimelineType { get; private set; }

	public static float? m_TurnWaitP2P { private get; set; }

	public static float? m_TurnWaitP2E { private get; set; }

	public static float? m_TurnWaitE2E { private get; set; }

	public static float? m_TurnWaitE2P { private get; set; }

	public static float? m_TurnWaitP2EMove { private get; set; }

	public static float? m_TurnWaitE2PMove { private get; set; }

	public static float GetTurnWaitP2P()
	{
		return 0f;
	}

	public static float GetTurnWaitP2E()
	{
		return 0f;
	}

	public static float GetTurnWaitE2E()
	{
		return 0f;
	}

	public static float GetTurnWaitE2P()
	{
		return 0f;
	}

	public static float GetTurnWaitP2EMove()
	{
		return 0f;
	}

	public static float GetTurnWaitE2PMove()
	{
		return 0f;
	}

	public static void SetBtlTimelineType(BtlTimelineType type)
	{
	}
}
