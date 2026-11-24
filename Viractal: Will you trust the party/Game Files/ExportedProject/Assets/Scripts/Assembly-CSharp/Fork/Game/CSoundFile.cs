using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriWare;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Fork.Game
{
	public class CSoundFile
	{
		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public CriAtomExAcbLoader acbLoader;

			internal bool _003CLoadAsync_003Eb__0()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<long> _003C_003Et__builder;

			public string acbPath;

			public CSoundFile _003C_003E4__this;

			private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

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

		private static long mHandleCount;

		public long mHandle;

		public CriAtomExAcb mAcb;

		private Dictionary<int, List<ushort>> mCategoryTbl;

		public long Load(string acbPath)
		{
			return 0L;
		}

		[AsyncStateMachine(typeof(_003CLoadAsync_003Ed__6))]
		public UniTask<long> LoadAsync(string acbPath)
		{
			return default;
		}

		public void Decrypt(ulong decryptKey)
		{
		}

		public void UnsetCategory()
		{
		}

		public void UnsetCategory(int cueId)
		{
		}

		public void UnsetCategory(string cueName)
		{
		}

		public void UnsetCategoryByIndex(int index)
		{
		}

		public void UnsetCategory(int cueId, ushort category)
		{
		}

		public void UnsetCategory(string cueName, ushort category)
		{
		}

		public void UnsetCategoryByIndex(int index, ushort category)
		{
		}

		public void UnsetCategories(int cueId, ushort[] categories)
		{
		}

		public void UnsetCategories(string cueName, ushort[] categories)
		{
		}

		public void UnsetCategoriesByIndex(int index, ushort[] categories)
		{
		}

		public void SetDefaultCategory()
		{
		}

		public void AddCategories(int cueId, ushort[] categories)
		{
		}

		public void AddCategories(string cueName, ushort[] categories)
		{
		}

		public void AddCategoriesByIndex(int index, ushort[] categories)
		{
		}

		public void AddCategories(ushort[] categories)
		{
		}

		public void AddCategories(int cueId, string[] categories)
		{
		}

		public void AddCategories(string cueName, string[] categories)
		{
		}

		public void AddCategoriesByIndex(int index, string[] categories)
		{
		}

		public void AddCategories(string[] categories)
		{
		}

		public void AddCategory(int cueId, ushort categoryId)
		{
		}

		public void AddCategory(int cueId, string categoryName)
		{
		}

		public void AddCategory(string cueName, ushort categoryId)
		{
		}

		public void AddCategory(string cueName, string categoryName)
		{
		}

		public void AddCategoryByIndex(int index, ushort categoryId)
		{
		}

		public void AddCategoryByIndex(int index, string categoryName)
		{
		}

		public void AddCategory(ushort categoryId)
		{
		}

		public void AddCategory(string categoryName)
		{
		}

		public ushort[] GetCategories(int cueId)
		{
			return null;
		}

		public ushort[] GetCategories(string cueName)
		{
			return null;
		}

		public ushort[] GetCategoriesByIndex(int index)
		{
			return null;
		}

		public int CueNameToId(string name)
		{
			return 0;
		}

		public string CueIdToName(int id)
		{
			return null;
		}
	}
}
