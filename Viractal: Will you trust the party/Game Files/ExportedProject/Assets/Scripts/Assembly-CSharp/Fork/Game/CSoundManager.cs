using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CriWare;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Fork.Game
{
	public class CSoundManager
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CBGMLoadAsync_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<long> _003C_003Et__builder;

			public CSoundManager _003C_003E4__this;

			public string acbAddress;

			public ulong decryptKey;

			public int index;

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
		private struct _003CLoadSoundAsync_003Ed__67 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<long> _003C_003Et__builder;

			public string acbAddress;

			public ulong decryptKey;

			public CSoundManager _003C_003E4__this;

			private CSoundFile _003CsoundFile_003E5__2;

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
		private struct _003CRegisterAcfAsync_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public CSoundManager _003C_003E4__this;

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
		private struct _003CSELoadAsync_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<long> _003C_003Et__builder;

			public CSoundManager _003C_003E4__this;

			public string acbAddress;

			public ulong decryptKey;

			public int index;

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
		private struct _003CVoiceLoadAsync_003Ed__54 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<long> _003C_003Et__builder;

			public CSoundManager _003C_003E4__this;

			public string acbAddress;

			public ulong decryptKey;

			public int index;

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

		private CSoundHandleList mSoundHandleList;

		private CBGMPlayer mBGMPlayer;

		private CSEPlayer mSEPlayer;

		private CVoicePlayer mVoicePlayer;

		private CriAtomEx3dListener mDefault3dListener;

		private Dictionary<long, CSoundFile> mSoundFileTbl;

		private float mBGMMasterVolume;

		private float mSEMasterVolume;

		private float mVoiceMasterVolume;

		private float mMasterVolume;

		private bool mRegisterAcf;

		private bool mBinauralizer;

		public CBGMPlayer BGMPlayer => null;

		public CSEPlayer SEPlayer => null;

		public CVoicePlayer VoicePlayer => null;

		public CriAtomEx3dListener Default3dListener => null;

		public bool Binauralizer => false;

		public CSoundManager(int bgmMaxCh, int seMaxCh, int voiceMaxCh, CriWareDecrypter.Config decrypterConfig = null)
		{
		}

		public void Destroy()
		{
		}

		public void RegisterAcf(string acfAddress)
		{
		}

		[AsyncStateMachine(typeof(_003CRegisterAcfAsync_003Ed__25))]
		public UniTask RegisterAcfAsync(string acfAddress)
		{
			return default;
		}

		public void UnRegisterAcf()
		{
		}

		public long BGMLoad(string acbAddress, int index, ulong decryptKey = 0uL)
		{
			return 0L;
		}

		[AsyncStateMachine(typeof(_003CBGMLoadAsync_003Ed__28))]
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

		public CSoundChannel GetBGMSoundChannel(int channel)
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

		public void SetBGM3dListener(CriAtomEx3dListener listener)
		{
		}

		public long BGMPlay(int channel, string name, float volume = 1f, float pitch = 0f, int priority = 0, CriAtomEx3dSource source = null, CriAtomEx3dListener listener = null)
		{
			return 0L;
		}

		public long BGMPlay(int channel, int reqId, float volume = 1f, float pitch = 0f, int priority = 0, CriAtomEx3dSource source = null, CriAtomEx3dListener listener = null)
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

		[AsyncStateMachine(typeof(_003CSELoadAsync_003Ed__42))]
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

		public void SetSE3dListener(CriAtomEx3dListener listener)
		{
		}

		public long SEPlay(string reqName, float volume = 1f, float pitch = 0f, int priority = 0, CriAtomEx3dSource source = null, CriAtomEx3dListener listener = null)
		{
			return 0L;
		}

		public long SEPlay(int reqId, float volume = 1f, float pitch = 0f, int priority = 0, CriAtomEx3dSource source = null, CriAtomEx3dListener listener = null)
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

		[AsyncStateMachine(typeof(_003CVoiceLoadAsync_003Ed__54))]
		public UniTask<long> VoiceLoadAsync(string acbAddress, int index, ulong decryptKey = 0uL)
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

		public void SetVoice3dListener(CriAtomEx3dListener listener)
		{
		}

		public long VoicePlay(string name, float volume = 1f, float pitch = 0f, int priority = 0, CriAtomEx3dSource source = null, CriAtomEx3dListener listener = null)
		{
			return 0L;
		}

		public long VoicePlay(int reqId, float volume = 1f, float pitch = 0f, int priority = 0, CriAtomEx3dSource source = null, CriAtomEx3dListener listener = null)
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

		public long LoadSound(string acbAddress, ulong decryptKey = 0uL)
		{
			return 0L;
		}

		[AsyncStateMachine(typeof(_003CLoadSoundAsync_003Ed__67))]
		public UniTask<long> LoadSoundAsync(string acbAddress, ulong decryptKey = 0uL)
		{
			return default;
		}

		public float ActualVolume(float volume)
		{
			return 0f;
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

		public SoundStatus GetStatus(long handle)
		{
			return SoundStatus.Stop;
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

		public void AttachAisac(long handle, string globalAisacName)
		{
		}

		public void AttachAisac(ushort categoryId, string globalAisacName)
		{
		}

		public void AttachAisac(string categoryName, string globalAisacName)
		{
		}

		public void DetachAisac(long handle, string globalAisacName)
		{
		}

		public void DetachAisac(ushort categoryId, string globalAisacName)
		{
		}

		public void DetachAisac(string categoryName, string globalAisacName)
		{
		}

		public void SetAisacControl(long handle, string aisacControlName, float value)
		{
		}

		public void SetAisacControl(long handle, uint aisacControlId, float value)
		{
		}

		public void SetAisacControl(ushort category, int aisacControlId, float value)
		{
		}

		public void SetAisacControl(string category, string aisacControlName, float value)
		{
		}

		public void SetAisacControl(ushort categoryId, string aisacControlName, float value)
		{
		}

		public void SetAisacControl(string categoryName, int aisacControlId, float value)
		{
		}

		public void SetDefault3dListener(CriAtomEx3dListener listener)
		{
		}

		public CriAtomEx3dSource Get3dSource(long handle)
		{
			return null;
		}

		public void EnableBinauralizer(bool binauralizer)
		{
		}

		public bool IsEnabledBinauralizer()
		{
			return false;
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
	}
}
