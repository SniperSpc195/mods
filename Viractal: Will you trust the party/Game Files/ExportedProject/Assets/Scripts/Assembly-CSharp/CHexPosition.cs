using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class CHexPosition
{
	public class ADD_MODEL
	{
		public uint mFlag;

		public string mName;

		public GameObject mGameObject;

		public ADD_MODEL(uint flag, GameObject g)
		{
		}

		public void Destroy()
		{
		}
	}

	public Vector3Int mHexPosition;

	public Vector3 mWorldPosition;

	public Transform mParent;

	public GameObject mHex;

	public Transform mMoveMark;

	public Transform mMoveNum;

	public Transform mJudgementOnLadder;

	public int mNumTexture;

	public Transform mGround;

	public string mGroundId;

	public int mGroundAngle;

	public int mGroundTex;

	public string mAreaID;

	private string mDetail;

	private CEventEnum.EVID mEnemy;

	private bool mPass;

	private uint mFlag;

	private GameObject mObject;

	private CHexObjectScale mHexObjectScale;

	private MaterialPropertyBlock mMaterialPropertyBlock;

	private List<ADD_MODEL> mAddModels;

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

	public string Detail => null;

	public string GroundId
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Vector3Int GetHexPosition()
	{
		return default;
	}

	public Vector3 GetFloorPosition()
	{
		return default;
	}

	public void SetFlag(uint a)
	{
	}

	public void OrFlag(uint a)
	{
	}

	public void ClearFlag(uint a)
	{
	}

	public bool IsFlag(uint a)
	{
		return false;
	}

	public bool IsCloud()
	{
		return false;
	}

	public bool IsLadder()
	{
		return false;
	}

	public bool IsAddLadder()
	{
		return false;
	}

	public string GetDetail()
	{
		return null;
	}

	public CMaster_HexDetailData GetDetailData()
	{
		return null;
	}

	public CMaster_MapTownData GetTownData()
	{
		return null;
	}

	public float GetWorldDistance(CHexPosition a)
	{
		return 0f;
	}

	public float GetWorldDistance(Vector3 a)
	{
		return 0f;
	}

	public int CheckHeight(CHexPosition hex)
	{
		return 0;
	}

	public CHexDef.DIR GetHexDir(CHexPosition hex)
	{
		return CHexDef.DIR.LeftForward;
	}

	public CHexPosition(Transform parent, GameObject hex, Vector3Int i3)
	{
	}

	public void SetDupMove(GameObject dup)
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	public void SetEnemy(CEventEnum.EVID a)
	{
	}

	public bool IsEnemy()
	{
		return false;
	}

	public CEventEnum.EVID GetEnemy()
	{
		return CEventEnum.EVID._000;
	}

	public bool IsPass()
	{
		return false;
	}

	public bool IsEqualXZ(Vector3Int a)
	{
		return false;
	}

	public void MoveActive(bool a, int backHeight = -2)
	{
	}

	public void SetNum(int n, int backHeight = -2)
	{
	}

	public void AddObject(string detail, GameObject g, Vector3 angles)
	{
	}

	public void RemoveObject()
	{
	}

	public bool IsExistObject()
	{
		return false;
	}

	public CHexObjectScale GetHexObjectScale()
	{
		return null;
	}

	public void RotateObject(float angleY)
	{
	}

	public void RotateGround(float angleY)
	{
	}

	public void ChangeGround(string groundId, GameObject gameObject, int groundTex, int angleY)
	{
	}

	public GameObject AddModel(uint flag, GameObject g)
	{
		return null;
	}

	public bool RemoveModel(uint flag)
	{
		return false;
	}

	public CHexCloud GetCloud()
	{
		return null;
	}
}
