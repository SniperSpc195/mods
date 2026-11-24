using UnityEngine;

public static class Vectormath
{
	public static float Distance(this Ray i_Ray, Vector3 i_Point)
	{
		return 0f;
	}

	public static Vector3 ClosestPoint(this Ray i_Ray, Vector3 i_Point)
	{
		return default;
	}

	public static bool TryGetIntersection(this Ray i_Ray, Sphere i_Sphere, out Vector3 o_IntersectPoint)
	{
		o_IntersectPoint = default;
		return false;
	}

	public static bool TryGetIntersection(this Ray i_Ray, Plane i_Plane, out Vector3 o_IntersectPoint, out float o_Distance)
	{
		o_IntersectPoint = default;
		o_Distance = default;
		return false;
	}
}
