using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CGameObjectActivator : MonoBehaviour
{
	public struct Hierarchy
	{
		public GameObject node;

		public string name;

		public bool open;

		public bool searchMatch;
	}

	private enum Seq
	{
		None = 0,
		Hierarchy = 1,
		SearchDialog = 2
	}

	[SerializeField]
	private CDebugTabMenu m_OrgMenu;

	[SerializeField]
	private TextMeshProUGUI m_OperationInfoText;

	[SerializeField]
	private TextMeshProUGUI m_SearchInfoText;

	[SerializeField]
	[Header("検索")]
	private CDebugInputFieldDialog m_SearchDialog;

	private List<Hierarchy>[] m_GameObjects;

	private List<Hierarchy> m_TreeViewItems;

	private List<string>[] m_GameObjectsName;

	private Seq m_Seq;

	private bool m_SearchMode;

	private List<string> m_SceneNames;

	private void Start()
	{
	}

	public void CreateTreeView(int i_Tab, bool i_Rebuild)
	{
	}

	private void OnDecideButton(CTreeView.ButtonParam i_ButtonParam)
	{
	}

	private void OnOpen()
	{
	}

	private void RefleshHierarchy()
	{
	}

	private void GetChildrenGameObject(List<Hierarchy> list, GameObject go)
	{
	}

	private void SearchStart()
	{
	}

	private void SearchClose()
	{
	}

	private void ShowOperationInfo()
	{
	}

	private void ShowSearchInfo()
	{
	}

	private void HideSearchInfo()
	{
	}

	private void ClearSearch()
	{
	}

	private void Update()
	{
	}
}
