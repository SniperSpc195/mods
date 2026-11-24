using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CBattleEnemy : CBattleCharDef
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public CBtlEncountCamera encountCam;

		internal bool _003C_PlayBossDeadAnime_003Eb__0()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_PlayBossDeadAnime_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleEnemy _003C_003E4__this;

		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003C_PlayBossDeadAnime_003Ed__41(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003C_PlayStartupEffect_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CBattleEnemy _003C_003E4__this;

		public Transform parent;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003C_PlayStartupEffect_003Ed__36(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	[ReadOnly]
	public CParamEnemy mParam;

	private IEnumerator m_BossDaedAnime;

	public CMaster_EnemyData m_Data { get; private set; }

	public CFieldEnemy m_FieldEnemy { get; private set; }

	public bool m_HasItem { get; private set; }

	public bool m_HasGold { get; private set; }

	public bool m_Escaped { get; private set; }

	public void Setup(CMaster_EnemyData enemy, CFieldEnemy fieldEnemy, int rushIndex, int index)
	{
	}

	public override void ReloadActionScript()
	{
	}

	public override CParamDef GetParam()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	public override string ID()
	{
		return null;
	}

	public override string Name()
	{
		return null;
	}

	private void Start()
	{
	}

	protected override void LateUpdate()
	{
	}

	public void ExecuteActionRoutine()
	{
	}

	public CMaster_TreasureTableData LotteryDropItem(int i_DropRank, int i_BoxIndex = -1)
	{
		return null;
	}

	public void DelHasItem()
	{
	}

	public void DelHasGold()
	{
	}

	public static bool IsExistDropItem(string id)
	{
		return false;
	}

	public static void GetDropItemName(string id, out string name)
	{
		name = null;
	}

	[IteratorStateMachine(typeof(_003C_PlayStartupEffect_003Ed__36))]
	protected override IEnumerator _PlayStartupEffect(Transform parent)
	{
		return null;
	}

	public override Vector3 GetPedestalHeight(bool scale)
	{
		return default;
	}

	public override void SetWorldPosition(Vector3 position)
	{
	}

	public override void PlayDeadAnime(Vector3? vecForce = null)
	{
	}

	public void PlayBossDeadAnime()
	{
	}

	[IteratorStateMachine(typeof(_003C_PlayBossDeadAnime_003Ed__41))]
	private IEnumerator _PlayBossDeadAnime()
	{
		return null;
	}

	public bool IsPlayingBossDeadAnime()
	{
		return false;
	}

	public void SetEscape()
	{
	}

	public override Dictionary<string, object> Save(Dictionary<string, object> i_Dict)
	{
		return null;
	}

	public override void Load(JsonNode i_JsonNode)
	{
	}
}
