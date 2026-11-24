using System.Collections.Generic;
using UnityEngine;

public class CFieldEventObject : CCharDef
{
	public string mObjectID;

	public bool mExtinction;

	public CParamInt mWorkExtinction;

	private Transform mObjectModel;

	public CMaster_EventObjectData GetEventObjectData()
	{
		return null;
	}

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private new void LateUpdate()
	{
	}

	public Dictionary<string, object> Save()
	{
		return null;
	}

	public void Load(JsonNode save)
	{
	}
}
