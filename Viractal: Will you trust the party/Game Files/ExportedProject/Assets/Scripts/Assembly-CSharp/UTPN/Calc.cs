using System.Collections.Generic;
using UnityEngine;

namespace UTPN
{
	public class Calc
	{
		public enum FAST
		{
			Normal = 0,
			Double = 1,
			Hi = 2
		}

		private const float mLittleFaster = 1.3333f;

		private static float[] mFastRate;

		private static FAST mFast;

		public static void SetFast(FAST a)
		{
		}

		public static FAST GetFast()
		{
			return FAST.Normal;
		}

		public static bool IsFastNormal()
		{
			return false;
		}

		public static bool IsFast()
		{
			return false;
		}

		public static float GetFastRate()
		{
			return 0f;
		}

		public static float GetDeltaOne(bool fast = true)
		{
			return 0f;
		}

		public static float GetDeltaOne(float limit)
		{
			return 0f;
		}

		public static float GetDeltaOne(float[] list)
		{
			return 0f;
		}

		public static float GetSpeedSec(float t, bool multipleDeltaOne = true)
		{
			return 0f;
		}

		public static bool Position3DtoUI(RectTransform parent, Camera camera, Vector3 position, ref Vector2 v2)
		{
			return false;
		}

		public static float GetZAngle(Vector3 src, Vector3 target, bool normal = true)
		{
			return 0f;
		}

		public static float AngleNormal(float f)
		{
			return 0f;
		}

		public static float AngleDifference(float src, float tgt)
		{
			return 0f;
		}

		public static float RotateAngle(float src, float tgt, float spd)
		{
			return 0f;
		}

		public static Vector2 RotationZv2(float scale, float angle)
		{
			return default;
		}

		public static Vector2 RotationZv2(Vector2 v, float angle)
		{
			return default;
		}

		public static Vector3 ArcVector(Vector3 st, Vector3 ed, Vector3 up, float height, float cnt)
		{
			return default;
		}

		public static Vector3 LineHarfPosition(Vector3 a, Vector3 b)
		{
			return default;
		}

		public static List<Vector3> Spline(List<Vector3> inVec, float sp_step)
		{
			return null;
		}

		public static List<Vector2> Spline(List<Vector2> inVec, float sp_step)
		{
			return null;
		}

		private static float Coefficent(float t)
		{
			return 0f;
		}
	}
}
