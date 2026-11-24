using UnityEngine;
using UnityEngine.InputSystem;

public class CExitGameDialog : SingletonMonoBehaviour<CExitGameDialog>
{
	private enum MODE
	{
		None = 0,
		Inquiry = 1,
		Wait = 2,
		Exit = 3
	}

	[SerializeField]
	private CUIGenericDialog mDialog;

	private bool mActiveDialog;

	[SerializeField]
	[ReadOnly]
	private CUIGenericFocus[] mFocus;

	[SerializeField]
	[ReadOnly]
	private MODE mMode;

	[SerializeField]
	[ReadOnly]
	private bool mPermission;

	private long mTime;

	private int mEdgeEsc;

	private float mWait;

	public bool IsExecute()
	{
		return false;
	}

	public void SetPermission(bool a)
	{
	}

	private void Awake()
	{
	}

	private void CheckKey(Keyboard kb)
	{
	}

	private bool IsEscOn()
	{
		return false;
	}

	private bool IsEscEdge()
	{
		return false;
	}

	public bool IsMouseFocus(CUIGenericFocus focus)
	{
		return false;
	}

	private bool IsRun()
	{
		return false;
	}

	public bool OpenDialog()
	{
		return false;
	}

	private void _OpenDialog()
	{
	}

	private void Update()
	{
	}

	public bool MenuExec()
	{
		return false;
	}
}
