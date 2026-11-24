using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriWare;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Fork.Game
{
	public class CSound : SingletonMonoBehaviour<CSound>
	{
		public enum Status
		{
			Stop = 0,
			Play = 1,
			Pause = 2
		}

		public enum SE
		{
			None = -1,
			Cursor = 0,
			Ok = 1,
			Cancel = 2,
			Ng = 3,
			_Max = 4
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CBGMLoadAsync_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<long> _003C_003Et__builder;

			public CSound _003C_003E4__this;

			public string acbAddress;

			public int index;

			public ulong decryptKey;

			private UniTask<long>.Awaiter _003C_003Eu__1;

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
		private struct _003CRegisterAcfAsync_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CSound _003C_003E4__this;

			public string acfAddress;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CSELoadAsync_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<long> _003C_003Et__builder;

			public CSound _003C_003E4__this;

			public string acbAddress;

			public int index;

			public ulong decryptKey;

			private UniTask<long>.Awaiter _003C_003Eu__1;

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
		private struct _003CVoiceLoadAsync_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<long> _003C_003Et__builder;

			public CSound _003C_003E4__this;

			public string acbAddress;

			public int index;

			public ulong decriptKey;

			private UniTask<long>.Awaiter _003C_003Eu__1;

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

		private static bool m_Initialize;

		public static readonly ushort m_DefaultCrossfadeMillsec;

		private CSoundManager mSoundManager;

		private float mMasterVolume;

		private bool mWatchSoundStatus;

		public static readonly string BGMTitle;

		public static readonly string BGMRoom;

		private int[] mReqSeNum;

		public bool Binauralizer => false;

		public static bool IsInitialize()
		{
			return false;
		}

		private void Awake()
		{
		}

		public void Destroy()
		{
		}

		public void Initialize(int bgmCh, int seCh, int voiceCh, CriWareDecrypter.Config decrypterConfig = null)
		{
		}

		public void RegisterAcf(string acfAddress)
		{
		}

		[AsyncStateMachine(typeof(_003CRegisterAcfAsync_003Ed__13))]
		public UniTask RegisterAcfAsync(string acfAddress)
		{
			return default;
		}

		public long BGMLoad(string acbAddress, int index, ulong decryptKey = 0uL)
		{
			return 0L;
		}

		[AsyncStateMachine(typeof(_003CBGMLoadAsync_003Ed__15))]
		public UniTask<long> BGMLoadAsync(string acbAddress, int index, ulong decryptKey = 0uL)
		{
			return default;
		}

		public int GetBGMListCount()
		{
			return 0;
		}

		public string[] GetBGMNameList()
		{
			return null;
		}

		public void SetBGMMasterVolume(float vol)
		{
		}

		public float GetBGMMasterVolume()
		{
			return 0f;
		}

		public long BGMPlay(int channel, string name, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public long BGMPlay(int channel, string name, Vector3 position, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public long BGMPlay(int channel, int reqId, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public long BGMPlay(int channel, int reqId, Vector3 position, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public void SetBGMCrossFadeTime(ushort ms)
		{
		}

		public void BGMStopAll()
		{
		}

		public void BGMMute(bool mute)
		{
		}

		public bool IsBGMMuted()
		{
			return false;
		}

		public long SELoad(string acbAddress, int index, ulong decryptKey = 0uL)
		{
			return 0L;
		}

		[AsyncStateMachine(typeof(_003CSELoadAsync_003Ed__29))]
		public UniTask<long> SELoadAsync(string acbAddress, int index, ulong decryptKey = 0uL)
		{
			return default;
		}

		public int GetSEListCount()
		{
			return 0;
		}

		public string[] GetSENameList()
		{
			return null;
		}

		public void SetSEMasterVolume(float vol)
		{
		}

		public float GetSEMasterVolume()
		{
			return 0f;
		}

		public long SEPlay(string reqName, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public long SEPlay(string reqName, Vector3 position, float volume = 1f, float pitch = 0f, int priority = 1, CriAtomEx3dListener listener = null)
		{
			return 0L;
		}

		public long SEPlay(int reqId, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public long SEPlay(int reqId, Vector3 position, float volume = 1f, float pitch = 0f, int priority = 1, CriAtomEx3dListener listener = null)
		{
			return 0L;
		}

		public long SEPlay(SE reqId, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public long SEPlay(SE reqId, Vector3 position, float volume = 1f, float pitch = 0f, int priority = 1, CriAtomEx3dListener listener = null)
		{
			return 0L;
		}

		public void SEStopAll()
		{
		}

		public void SEMute(bool mute)
		{
		}

		public bool IsSEMuted()
		{
			return false;
		}

		public long VoiceLoad(string acbAddress, int index, ulong decryptKey = 0uL)
		{
			return 0L;
		}

		[AsyncStateMachine(typeof(_003CVoiceLoadAsync_003Ed__44))]
		public UniTask<long> VoiceLoadAsync(string acbAddress, int index, ulong decriptKey = 0uL)
		{
			return default;
		}

		public int GetVoiceListCount()
		{
			return 0;
		}

		public string[] GetVoiceNameList()
		{
			return null;
		}

		public void SetVoiceMasterVolume(float vol)
		{
		}

		public float GetVoiceMasterVolume()
		{
			return 0f;
		}

		public long VoicePlay(string name, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public long VoicePlay(string name, Vector3 position, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public long VoicePlay(int reqId, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public long VoicePlay(int reqId, Vector3 position, float volume = 1f, float pitch = 0f, int priority = 0)
		{
			return 0L;
		}

		public void VoiceStopAll()
		{
		}

		public void VoiceMute(bool mute)
		{
		}

		public bool IsVoiceMuted()
		{
			return false;
		}

		public void Update()
		{
		}

		public void SetMasterVolumeAll(float volume)
		{
		}

		public float GetMasterVolumeAll()
		{
			return 0f;
		}

		public void StopAll()
		{
		}

		public void PauseAll()
		{
		}

		public void ResumeAll()
		{
		}

		public void Stop(long handle, bool ignoreReleaseTime = false)
		{
		}

		public void Pause(long handle)
		{
		}

		public void Resume(long handle)
		{
		}

		public void FadeIn(long handle, int ms)
		{
		}

		public void FadeOut(long handle, int ms)
		{
		}

		public void FadeTo(long handle, ushort ms, float volume, Action callback = null)
		{
		}

		public void FadeOutPause(long handle, ushort ms)
		{
		}

		public void ResumeFadeIn(long handle, ushort ms)
		{
		}

		public void SetVolume(long handle, float volume)
		{
		}

		public void SetPitch(long handle, float pitch)
		{
		}

		public Status GetStatus(long handle)
		{
			return Status.Stop;
		}

		public CSoundChannel GetBGMSoundChannel(int channel)
		{
			return null;
		}

		public CSoundChannel GetSoundChannel(long handle)
		{
			return null;
		}

		public void SetBusSendLevel(long handle, string busName, float sendLevel)
		{
		}

		public void UnsetCategory(long fileHandle)
		{
		}

		public void UnsetCategory(long fileHandle, int cueId)
		{
		}

		public void UnsetCategory(long fileHandle, string cueName)
		{
		}

		public void UnsetCategoryByIndex(long fileHandle, int index)
		{
		}

		public void UnsetCategory(long fileHandle, int cueId, ushort category)
		{
		}

		public void UnsetCategory(long fileHandle, string cueName, ushort category)
		{
		}

		public void UnsetCategoryByIndex(long fileHandle, int index, ushort category)
		{
		}

		public void UnsetCategories(long fileHandle, int cueId, ushort[] categories)
		{
		}

		public void UnsetCategories(long fileHandle, string cueName, ushort[] categories)
		{
		}

		public void UnsetCategoriesByIndex(long fileHandle, int index, ushort[] categories)
		{
		}

		public void SetDefaultCategory(long fileHandle)
		{
		}

		public void AddCategory(long fileHandle, ushort categoryId)
		{
		}

		public void AddCategory(long fileHandle, string categoryName)
		{
		}

		public void AddCategory(long fileHandle, int cueId, ushort categoryId)
		{
		}

		public void AddCategory(long fileHandle, int cueId, string categoryName)
		{
		}

		public void AddCategory(long fileHandle, string cueName, ushort categoryId)
		{
		}

		public void AddCategory(long fileHandle, string cueName, string categoryName)
		{
		}

		public void AddCategoryByIndex(long fileHandle, int index, ushort categoryId)
		{
		}

		public void AddCategoryByIndex(long fileHandle, int index, string categoryName)
		{
		}

		public void AddCategories(long fileHandle, ushort[] categories)
		{
		}

		public void AddCategories(long fileHandle, string[] categories)
		{
		}

		public void AddCategories(long fileHandle, int cueId, ushort[] categories)
		{
		}

		public void AddCategories(long fileHandle, int cueId, string[] categories)
		{
		}

		public void AddCategories(long fileHandle, string cueName, ushort[] categories)
		{
		}

		public void AddCategories(long fileHandle, string cueName, string[] categories)
		{
		}

		public void AddCategoriesByIndex(long fileHandle, int index, ushort[] categories)
		{
		}

		public void AddCategoriesByIndex(long fileHandle, int index, string[] categories)
		{
		}

		public ushort[] GetCategories(long fileHandle, int cueId)
		{
			return null;
		}

		public ushort[] GetCategories(long fileHandle, string cueName)
		{
			return null;
		}

		public ushort[] GetCategoriesByIndex(long fileHandle, int index)
		{
			return null;
		}

		public void AttachAisac(ushort categoryId, string globalAisacName)
		{
		}

		public void AttachAisac(string categoryName, string globalAisacName)
		{
		}

		public void AttachAisac(long handle, string globalAisacName)
		{
		}

		public void DetachAisac(ushort categoryId, string globalAisacName)
		{
		}

		public void DetachAisac(string categoryName, string globalAisacName)
		{
		}

		public void DetachAisac(long handle, string globalAisacName)
		{
		}

		public void SetAisacControl(ushort categoryId, int aisacControlId, float value)
		{
		}

		public void SetAisacControl(ushort categoryId, string aisacControlName, float value)
		{
		}

		public void SetAisacControl(string categoryName, int aisacControlId, float value)
		{
		}

		public void SetAisacControl(string categoryName, string aisacControlName, float value)
		{
		}

		public void SetAisacControl(long handle, uint aisacControlId, float value)
		{
		}

		public void SetAisacControl(long handle, string aisacControlName, float value)
		{
		}

		public void SetDefault3dListener()
		{
		}

		public CriAtomEx3dSource Get3dSource(long handle)
		{
			return null;
		}

		public void ResetParameters3dSource(long handle)
		{
		}

		public void SetPosition3dSource(long handle, Vector3 position)
		{
		}

		public void SetVelocity3dSource(long handle, Vector3 velocity)
		{
		}

		public void SetOrientation3dSource(long handle, Vector3 front, Vector3 top)
		{
		}

		public void SetConeParameter3dSource(long handle, float insideAngle, float outsideAngle, float outsideVolume)
		{
		}

		public void SetMinMaxDistance3dSource(long handle, float minDistance, float maxDistance)
		{
		}

		public void SetInteriorPanField3dSource(long handle, float sourceRadius, float interiorDistance)
		{
		}

		public void SetDopplerFactor3dSource(long handle, float dopplerFactor)
		{
		}

		public void SetVolume3dSource(long handle, float volume)
		{
		}

		public void SetMaxAngleAisacDelta3dSource(long handle, float maxDelta)
		{
		}

		public void SetAttenuationDistanceSetting3dSource(long handle, bool flag)
		{
		}

		public bool GetAttenuationDistanceSetting3dSource(long handle)
		{
			return false;
		}

		public void SetRandomPositionConfig3dSource(long handle, CriAtomEx.Randomize3dConfig? config)
		{
		}

		public void SetRandomPositionList3dSource(long handle, Vector3[] positionList)
		{
		}

		public void Set3dRegion3dSource(long handle, CriAtomEx3dRegion region3d)
		{
		}

		public void SetListenerBasedElevationAngleAisacControlId3dSource(long handle, ushort aisacControlId)
		{
		}

		public void SetSourceBasedElevationAngleAisacControlId3dSource(long handle, ushort aisacControlId)
		{
		}

		public void SetDistanceAisacControlId3dSource(long handle, ushort aisacControlId)
		{
		}

		public CriAtomEx.NativeVector GetPosition3dSource(long handle)
		{
			return default;
		}

		public void WatchSoundStatus(bool watch)
		{
		}

		public bool GetWatchSoundStatus()
		{
			return false;
		}

		public void EnableBinauralizer(bool binauralizer)
		{
		}

		public void SetCategoryVolume(string category, float volume)
		{
		}

		public float GetCategoryVolume(string category)
		{
			return 0f;
		}

		public void SetCategoryVolume(int id, float volume)
		{
		}

		public float GetCategoryVolume(int id)
		{
			return 0f;
		}

		public void SetupReqSeNum()
		{
		}
	}
}
