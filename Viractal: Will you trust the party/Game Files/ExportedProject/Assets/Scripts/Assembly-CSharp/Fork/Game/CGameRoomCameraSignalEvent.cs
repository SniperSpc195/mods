using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Fork.Game
{
	public class CGameRoomCameraSignalEvent : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public CGameRoomCameraSignalEvent _003C_003E4__this;

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
			public _003CStart_003Ed__9(int _003C_003E1__state)
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

		private RenderTexture m_RenderTexture;

		private RawImage m_RawImage;

		private double m_StartTime;

		private float m_Dulation;

		private CCameraPostRender m_CameraPostRender;

		private int m_YieldOneFrame;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__9))]
		private IEnumerator Start()
		{
			return null;
		}

		private void CrossfadeStart(float i_Time = 0.1f)
		{
		}

		private void Update()
		{
		}
	}
}
