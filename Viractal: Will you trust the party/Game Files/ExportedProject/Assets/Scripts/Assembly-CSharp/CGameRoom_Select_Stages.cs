using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CGameRoom_Select_Stages : MonoBehaviour
{
	private enum MODE
	{
		End = 0,
		Select = 1,
		Inquly = 2
	}

	private class SelectableStages
	{
		public GameObject[] mNameSelected;

		public CMaster_MapStageData mData;

		public Sprite mSprite;

		public SelectableStages(CMaster_MapStageData data)
		{
		}

		public void Setup(Transform parent)
		{
		}

		public void Selected(bool a)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public CGameRoom_Select_Stages _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	private Image mImage;

	[SerializeField]
	private TextMeshProUGUI mDescription;

	[SerializeField]
	private CUIGenericMenu mMenu;

	private List<SelectableStages> mAllStages;

	private List<SelectableStages> mStages;

	private CMaster_MapStageData mSelectStage;

	private MODE mMode;

	private bool mCancel;

	public CMaster_MapStageData SelectStage => null;

	public void Active(bool a)
	{
	}

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__10))]
	public UniTask Initialize()
	{
		return default;
	}

	public void GoSelect(CMaster_MapStageData selected)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public bool IsCancel()
	{
		return false;
	}

	public bool IsDecision()
	{
		return false;
	}

	private void Update()
	{
	}

	private void SetDescription()
	{
	}

	private void Cb_Cancel()
	{
	}

	private void Cb_Decision(int n)
	{
	}
}
