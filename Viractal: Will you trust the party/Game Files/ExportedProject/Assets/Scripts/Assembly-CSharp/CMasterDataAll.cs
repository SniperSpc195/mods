using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

public class CMasterDataAll : ScriptableObject
{
	[Serializable]
	public class Data
	{
		public string id;

		public string file;

		public long data_length;

		public string md5;

		public ScriptableObject m_Reference;
	}

	public class MasterData
	{
		public string m_DataJson;

		public Func<string, string, ScriptableObject> m_Writer;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CInitialize_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		private JsonNode _003ClangFiles_003E5__2;

		private AsyncOperationHandle<TextAsset> _003Chandle_003E5__3;

		private UniTask<TextAsset>.Awaiter _003C_003Eu__1;

		private float _003Cprogress_003E5__4;

		private int _003Ci_003E5__5;

		private UniTask.Awaiter _003C_003Eu__2;

		private MasterData[] _003C_003E7__wrap5;

		private MasterData _003CmasterData_003E5__7;

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
	public Data[] m_Datas;

	private static string m_DownloadMasterPath;

	public static readonly MasterData[] m_AllDatas;

	public static CMaster_ModelData GetModelData(string id)
	{
		return null;
	}

	public static string GetDataMemberName(string id, bool addIcon = true)
	{
		return null;
	}

	public static TDatabase CreateAsset<TDatabase, TData>(string i_AssetName, string i_Json) where TDatabase : ScriptableObject, IDatabase<TData> where TData : IMasterData
	{
		return null;
	}

	public static TData[] Read<TData>(string i_Json)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CInitialize_003Ed__9))]
	public static UniTask Initialize()
	{
		return default;
	}
}
