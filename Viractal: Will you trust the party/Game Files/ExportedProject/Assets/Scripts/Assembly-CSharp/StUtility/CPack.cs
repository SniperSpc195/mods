using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace StUtility
{
	public class CPack
	{
		public enum FileType
		{
			Bin = 0,
			Png = 1,
			Bmp = 2,
			Webp = 3
		}

		private class CMainHeader
		{
			public uint m_PackCount;
		}

		private class CFileHeader
		{
			public string m_FileName;

			public string m_BaseName;

			public FileType m_FileType;

			public byte[] m_Prm;

			public CBinaryData m_Binary;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitializeAsync_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public string i_FileName;

			public CancellationToken i_CancellationToken;

			public CPack _003C_003E4__this;

			private AsyncOperationHandle<TextAsset> _003Chandle_003E5__2;

			private UniTask<TextAsset>.Awaiter _003C_003Eu__1;

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

		public const int m_PackFileNameMax = 48;

		private CMainHeader m_MainHeader;

		private CFileHeader[] m_FileHeader;

		private byte GetU8(byte[] i_buffer, int i_Offset)
		{
			return 0;
		}

		private ushort GetU16(byte[] i_buffer, int i_Offset)
		{
			return 0;
		}

		private uint GetU32(byte[] i_buffer, int i_Offset)
		{
			return 0u;
		}

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__10))]
		public UniTask InitializeAsync(string i_FileName, CancellationToken i_CancellationToken = default(CancellationToken))
		{
			return default;
		}

		public void Initialize(string i_FileName)
		{
		}

		public void Initialize(byte[] i_Buffer)
		{
		}

		private void _Initialize(byte[] i_Buffer)
		{
		}

		public CBinaryData GetFileBin(uint i_No)
		{
			return null;
		}

		public CBinaryData GetFileBin(string i_FileName)
		{
			return null;
		}

		public bool IsFileExist(string i_FileName)
		{
			return false;
		}

		public uint GetFileNumber()
		{
			return 0u;
		}

		public string GetFileName(uint i_No)
		{
			return null;
		}

		public string GetBaseName(uint i_No)
		{
			return null;
		}

		private bool _GetFileNo(ref uint i_No, string i_FileName)
		{
			return false;
		}

		private bool _GetFileNoBase(ref uint i_No, string i_BaseName)
		{
			return false;
		}

		public uint GetFileNo(string i_FileName)
		{
			return 0u;
		}

		public uint GetFileNoBase(string i_BaseName)
		{
			return 0u;
		}

		public uint GetFileSize(uint i_No)
		{
			return 0u;
		}

		public uint GetFileSize(string i_FileName)
		{
			return 0u;
		}

		public FileType GetFileType(uint i_No)
		{
			return FileType.Bin;
		}

		public FileType GetFileType(string i_FileName)
		{
			return FileType.Bin;
		}

		public byte GetPrm(uint i_No, int i_Index)
		{
			return 0;
		}

		public byte GetPrm(string i_FileName, int i_Index)
		{
			return 0;
		}
	}
}
