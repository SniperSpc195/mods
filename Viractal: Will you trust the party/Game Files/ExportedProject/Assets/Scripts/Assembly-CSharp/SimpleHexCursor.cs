using UnityEngine;

public class SimpleHexCursor : MonoBehaviour
{
	private Material mMaterial;

	public Vector3 mOffset;

	public Vector3Int mPosition;

	public Vector3 m3DPos;

	public GameObject mSelectObject;

	public bool IsExistObject => false;

	public Vector3 ObjectAngles
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public void SetPosition(Vector3Int p)
	{
	}

	public void SetPosition(CHexPosition hex)
	{
	}

	public int NextHeight()
	{
		return 0;
	}

	public void AddObject(GameObject g)
	{
	}

	public void RotateObject(float angleY)
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}
}
