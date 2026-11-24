using System.Collections.Generic;
using CriWare;
using UnityEngine;

[RequireComponent(typeof(CriAtomListener))]
[DefaultExecutionOrder(200)]
public class PrimaryListener : MonoBehaviour
{
	private static List<CriAtomListener> _CriAtomListeners;

	private CriAtomListener _CriAtomListener;

	[SerializeField]
	public float m_DopplerMultiplier;

	[SerializeField]
	public bool m_AutoMove;

	[SerializeField]
	[Tooltip("TargetPoint から m_TargetDistance 以上離れないよう、forward 方向に自動移動")]
	public float m_TargetDistance;

	[SerializeField]
	public Vector3 m_TargetPoint;

	[SerializeField]
	public bool m_ForceLookTarget;

	private Vector3 m_InitialLocalPosition;

	private Quaternion m_InitialLocalRotation;

	private CBattlePlayer previousPlayer;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private static void UpdateNativeListener()
	{
	}

	public void SetDopplerMultiplier(float i_Value)
	{
	}

	public void DisableListenerAutoMove()
	{
	}

	public void SetFocus(Vector3 i_Position, float i_MaxDitance)
	{
	}

	public static CriAtomEx3dListener NativeListener()
	{
		return null;
	}

	public static CriAtomListener CurrentListener()
	{
		return null;
	}

	public static Vector3 GetListenerPosition(CriAtomEx3dListener nativeListener)
	{
		return default;
	}

	private void Update()
	{
	}

	private bool _LateUpdate()
	{
		return false;
	}
}
