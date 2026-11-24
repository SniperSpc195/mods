using System;

[Serializable]
public class CMaster_MapBattleData : IMasterData
{
	[Serializable]
	public class CChr2XTable
	{
		public float chr2_x;

		public float chr2_y;

		public float chr2_z;
	}

	[Serializable]
	public class CChr3XTable
	{
		public float chr3_x;

		public float chr3_y;

		public float chr3_z;
	}

	[Serializable]
	public class CEne2XTable
	{
		public float ene2_x;

		public float ene2_y;

		public float ene2_z;
	}

	[Serializable]
	public class CEne3XTable
	{
		public float ene3_x;

		public float ene3_y;

		public float ene3_z;
	}

	public string id;

	public string map;

	public string effect;

	public bool gameover_poster;

	public float chr1_x;

	public float chr1_y;

	public float chr1_z;

	public CChr2XTable[] chr2_x_table;

	public CChr3XTable[] chr3_x_table;

	public float ene1_x;

	public float ene1_y;

	public float ene1_z;

	public CEne2XTable[] ene2_x_table;

	public CEne3XTable[] ene3_x_table;

	public string encount_camera;

	public string start_camera;

	public float will_x;

	public float will_z;

	public string ID => null;

	public string GetPrefabPath()
	{
		return null;
	}

	public string GetEffectPath()
	{
		return null;
	}
}
