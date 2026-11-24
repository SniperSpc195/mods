using System.Collections.Generic;
using Cinemachine;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[AddComponentMenu("Game/Timeline/TimelineReferenceChanger")]
[RequireComponent(typeof(PlayableDirector))]
public class CTimelineReferenceChanger : MonoBehaviour
{
	private struct BackupAnimation
	{
		public AnimationPlayableAsset playableAsset;

		public AnimationClip clip;
	}

	private class ChangeValue
	{
		public GameObject m_GameObject;

		public Animator m_Animator;

		public string m_AnimationName;

		public CinemachineBrain m_CameraBrain;

		public CinemachineVirtualCamera m_VirtualCamera;
	}

	[SerializeField]
	private PlayableDirector m_PlayableDirector;

	[Header("参照を変更するActivationTrackを登録する\nTrackGroupName ... Trackが属するTrackGroup名\nGameObject ... Trackが参照しているGameObjectを設定する")]
	[SerializeField]
	private CChangeReferenceGameObject[] m_ChangeReferencesGameObject;

	[Header("参照を変更するAnimationTrackを登録する\nTrackGroupName ... Trackが属するTrackGroup名\nAnimator ... Trackが参照しているAnimatorを設定するClipName ... アニメーションを変更したい場合Clip名を設定する")]
	[SerializeField]
	private CChangeReferenceAnimator[] m_ChangeReferencesAnimator;

	[Header("参照を変更するCinemachineTrackを登録する\nTrackGroupName ... Trackが属するTrackGroup名\nCinemachineBrain ... Trackが参照しているCameraBrainを設定する\nClipName ... VirtualCameraを変更したい場合Clip名を設定する")]
	[SerializeField]
	private CChangeReferenceCameraBrain[] m_ChangeReferencesCameraBrain;

	private List<BackupAnimation> m_BackupPlayableAsset;

	private Dictionary<string, ChangeValue> m_DestObjects;

	public PlayableDirector PlayableDirector => null;

	private void OnDestroy()
	{
	}

	public Transform GetSourceObjectTransform(string i_Key)
	{
		return null;
	}

	public void SetChangedReference(string i_Key, GameObject i_ReferenceGameObject)
	{
	}

	public void SetChangedReference(string i_Key, Animator i_ReferenceAnimator, string i_ClipName = "")
	{
	}

	public void SetChangedReference(string i_Key, CinemachineBrain i_ReferenceCamera)
	{
	}

	public void SetChangedReference(string i_Key, CinemachineBrain i_ReferenceCamera, CinemachineVirtualCamera i_VirtualCamera)
	{
	}

	private void Awake()
	{
	}

	public void Apply()
	{
	}
}
