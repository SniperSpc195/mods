using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CUIPhysicsShapeFocus : MonoBehaviour, ICanvasRaycastFilter
{
	public enum State
	{
		None = 0,
		Cursor = 1,
		Mouse = 2,
		Cursor_Mouse = 3
	}

	public class AchievementData
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadIcon_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public AchievementData _003C_003E4__this;

			public Scene scene;

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

		public CMaster_AchievementData mData;

		public CDefine.CryptInt mNum;

		public Sprite[] mIcon;

		public AchievementData(CMaster_AchievementData data, int num)
		{
		}

		private string GetIconPath(bool open)
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadIcon_003Ed__5))]
		public UniTask LoadIcon(Scene scene, CancellationToken token)
		{
			return default;
		}

		public Sprite GetIcon()
		{
			return null;
		}
	}

	private readonly List<Vector2> _verts;

	private Image mImage;

	[SerializeField]
	[ReadOnly]
	private int mIndex;

	[SerializeField]
	[ReadOnly]
	private Vector2Int mPosition;

	[SerializeField]
	[ReadOnly]
	private State mState;

	private AchievementData mAchievementData;

	public int Index => 0;

	public Vector2Int Position => default;

	public AchievementData GetAchievementData()
	{
		return null;
	}

	public void Initialize(int index, AchievementData aData = null)
	{
	}

	public bool ShowSoulIcon()
	{
		return false;
	}

	public string GetInfo(string soulColor)
	{
		return null;
	}

	public int GetSoulPoint()
	{
		return 0;
	}

	public bool IsRaycastLocationValid(Vector2 screenPoint, Camera eventCamera)
	{
		return false;
	}

	private static bool IsInPolygon(List<Vector2> polygon, Vector2 p)
	{
		return false;
	}

	private static float CrossProduct(Vector2 u, Vector2 v)
	{
		return 0f;
	}
}
