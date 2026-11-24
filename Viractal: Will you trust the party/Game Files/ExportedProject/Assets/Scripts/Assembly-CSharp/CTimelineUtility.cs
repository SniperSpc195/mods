using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class CTimelineUtility
{
	private static void _TraversalGetTrack<Type>(IEnumerable<PlayableBinding> outputs, string group_name, List<Type> result) where Type : TrackAsset
	{
	}

	public static Type[] TraversalGetTrack<Type>(TimelineAsset timeline, string group_name = "") where Type : TrackAsset
	{
		return null;
	}
}
