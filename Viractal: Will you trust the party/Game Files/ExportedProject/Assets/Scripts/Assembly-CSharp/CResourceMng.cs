using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

internal class CResourceMng
{
	private struct SPRITE_DATA
	{
		public string mScene;

		public string mAddrName;

		public AsyncOperationHandle<Sprite> mHandle;

		public Sprite mSprite;

		public AsyncOperationHandle<IList<Sprite>> mListHandle;

		public IList<Sprite> mList;

		public Dictionary<string, Sprite> mCache;

		public Sprite GetSprite(string name)
		{
			return null;
		}

		public void Release()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CLoadAsyncSprite_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string i_AddrName;

		public Scene scene;

		private string _003Cfilename_003E5__2;

		private SPRITE_DATA _003Cdata_003E5__3;

		private UniTask<Sprite>.Awaiter _003C_003Eu__1;

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
	private struct _003CLoadAsyncSpriteList_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public string i_AddrName;

		public Scene scene;

		private string _003Cfilename_003E5__2;

		private SPRITE_DATA _003Cdata_003E5__3;

		private UniTask<IList<Sprite>>.Awaiter _003C_003Eu__1;

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

	private static Dictionary<string, SPRITE_DATA> mSpriteData;

	private static Dictionary<string, List<AsyncOperationHandle<GameObject>>> mGameObject;

	private static Dictionary<string, List<AsyncOperationHandle<Texture2D>>> mTexture2D;

	private static Dictionary<string, List<AsyncOperationHandle<Sprite>>> mSprite;

	private static Dictionary<string, List<AsyncOperationHandle<IList<Sprite>>>> mSpriteList;

	private static Dictionary<string, List<AsyncOperationHandle<Texture>>> mTexture;

	public static string LoadText(string i_AddrName)
	{
		return null;
	}

	public static byte[] LoadBin(string i_AddrName)
	{
		return null;
	}

	public static string LocalFileText(string filePath)
	{
		return null;
	}

	public static byte[] LocalFileBin(string filePath)
	{
		return null;
	}

	public static AsyncOperationHandle<GameObject> LoadPrefab(Scene scene, string i_AddrName, Transform i_Parent)
	{
		return default;
	}

	public static AsyncOperationHandle<GameObject> LoadAsyncPrefab(Scene scene, string i_AddrName, Transform i_Parent)
	{
		return default;
	}

	public static AsyncOperationHandle<T> Load<T>(Scene scene, string i_AddrName) where T : Object
	{
		return default;
	}

	public static AsyncOperationHandle<T> LoadAsync<T>(Scene scene, string i_AddrName) where T : Object
	{
		return default;
	}

	public static AsyncOperationHandle<IList<T>> LoadIList<T>(Scene scene, string i_AddrName) where T : Object
	{
		return default;
	}

	public static AsyncOperationHandle<IList<T>> LoadAsyncIList<T>(Scene scene, string i_AddrName) where T : Object
	{
		return default;
	}

	public static void Unload(Scene scene, AsyncOperationHandle<GameObject> handle)
	{
	}

	public static void UnloadTexture2D(Scene scene, AsyncOperationHandle<Texture2D> handle)
	{
	}

	[AsyncStateMachine(typeof(_003CLoadAsyncSprite_003Ed__12))]
	public static UniTask LoadAsyncSprite(Scene scene, string i_AddrName)
	{
		return default;
	}

	public static Sprite LoadSprite(Scene scene, string i_AddrName)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CLoadAsyncSpriteList_003Ed__14))]
	public static UniTask LoadAsyncSpriteList(Scene scene, string i_AddrName)
	{
		return default;
	}

	public static void LoadSpriteList(Scene scene, string i_AddrName)
	{
	}

	public static void UnloadSpriteList(string i_AddrName)
	{
	}

	public static Sprite GetSprite(string fileName, string sliceName)
	{
		return null;
	}

	public static Sprite GetSprite(string name)
	{
		return null;
	}

	public static void UnloadSceneGameObject(string sceneName)
	{
	}

	public static void UnloadScene(string sceneName)
	{
	}

	private static void _UnloadScene<T>(string name, Dictionary<string, List<T>> dic)
	{
	}

	private static void _UnloadSceneSprite(string sceneName)
	{
	}

	private static void _AddDictionary<T>(string name, object handle, Dictionary<string, List<AsyncOperationHandle<T>>> dic)
	{
	}

	private static void _AddDictionaryList<T>(string name, object handle, Dictionary<string, List<AsyncOperationHandle<IList<T>>>> dic)
	{
	}

	private static void _AddHandleList<T>(Scene scene, AsyncOperationHandle<IList<T>> handle)
	{
	}

	private static void _AddHandle<T>(Scene scene, AsyncOperationHandle<T> handle)
	{
	}

	private static string _AddrNameMolding(string i_OriginalName)
	{
		return null;
	}
}
