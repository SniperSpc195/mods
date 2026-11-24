using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CDebugModelView : MonoBehaviour
{
	[SerializeField]
	private Transform mModelParent;

	[SerializeField]
	private CUIGenericMenu mTopMenu;

	private int mTopCursor;

	[SerializeField]
	private CUIGenericMenu mAnimeMenu;

	private int mAnimeCursor;

	[SerializeField]
	private Transform mAnimeInfo;

	[SerializeField]
	private TextMeshProUGUI[] mOtherInfo;

	[SerializeField]
	private TextMeshProUGUI[] mBodyInfo;

	[SerializeField]
	private TextMeshProUGUI[] mFaceInfo;

	[SerializeField]
	private GameObject mButton_Pause;

	[SerializeField]
	private GameObject mButton_Camera;

	[SerializeField]
	private GameObject mButton_Forward;

	private CMainCamera mCamera;

	private bool mCameraAcrive;

	private CMainCamera.MODE mCameraMode;

	[SerializeField]
	private SpeechBubbleRenderer m_SpeechBubbleRenderer;

	[SerializeField]
	private TMP_Dropdown m_SpeechBubbleNode;

	[SerializeField]
	private TMP_InputField m_SpeechBubbleOffsetX;

	[SerializeField]
	private TMP_InputField m_SpeechBubbleOffsetY;

	[SerializeField]
	private TMP_InputField m_SpeechBubbleOffsetZ;

	[SerializeField]
	private Button m_SpeechBubbleInstantiateButton;

	[SerializeField]
	private Selectable m_SpeechHideComponent;

	[SerializeField]
	private Sprite m_SpeechBubbleSprite;

	[SerializeField]
	private GameObject m_Axis;
}
