using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace StUtility
{
	internal class CResourceAddress
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CContainsAddressAsync_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public object i_AddrName;

			private AsyncOperationHandle<IList<IResourceLocation>> _003Clocations_003E5__2;

			private UniTask<IList<IResourceLocation>>.Awaiter _003C_003Eu__1;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CExists_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

			public object i_FilePath;

			private AsyncOperationHandle<IList<IResourceLocation>> _003Chandle_003E5__2;

			private TaskAwaiter<IList<IResourceLocation>> _003C_003Eu__1;

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

		public static bool ContainsAddress(object i_AddrName)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003CContainsAddressAsync_003Ed__1))]
		public static UniTask<bool> ContainsAddressAsync(object i_AddrName)
		{
			return default;
		}

		public static string LoadText(string i_AddrName)
		{
			return null;
		}

		public static byte[] LoadBin(string i_AddrName)
		{
			return null;
		}

		public static AsyncOperationHandle<T> Load<T>(string i_AddrName) where T : Object
		{
			return default;
		}

		public static AsyncOperationHandle<T> LoadAsync<T>(string i_AddrName) where T : Object
		{
			return default;
		}

		public static AsyncOperationHandle<IList<T>> LoadIList<T>(string i_AddrName) where T : Object
		{
			return default;
		}

		public static AsyncOperationHandle<IList<T>> LoadAsyncIList<T>(string i_AddrName) where T : Object
		{
			return default;
		}

		public static AsyncOperationHandle<IList<Sprite>> LoadSprites(string i_AddrName)
		{
			return default;
		}

		public static AsyncOperationHandle<IList<Sprite>> LoadAsyncSprites(string i_AddrName)
		{
			return default;
		}

		public static void Unload<T>(AsyncOperationHandle<T> i_Handle) where T : Object
		{
		}

		public static void Unload<T>(AsyncOperationHandle<IList<T>> i_Handle) where T : Object
		{
		}

		public static AsyncOperationHandle<GameObject> LoadInstance(string i_AddrName, Transform i_Parent)
		{
			return default;
		}

		public static AsyncOperationHandle<GameObject> LoadInstanceAsync(string i_AddrName, Transform i_Parent)
		{
			return default;
		}

		public static void UnloadInstance(AsyncOperationHandle<GameObject> i_Handle)
		{
		}

		[AsyncStateMachine(typeof(_003CExists_003Ed__15))]
		public static UniTask<bool> Exists(object i_FilePath)
		{
			return default;
		}

		private static string _AddrNameMolding(string i_OriginalName)
		{
			return null;
		}
	}
}
