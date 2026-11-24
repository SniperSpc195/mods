using System;
using UnityEngine;

public static class StringExtension
{
	public ref struct LineByCharEnumerator
	{
		private ReadOnlySpan<char> _str;

		private ReadOnlySpan<char> _separater;

		private bool _trimWhiteSpace;

		public LineSplitEntry Current { get; private set; }

		public LineByCharEnumerator(ReadOnlySpan<char> str, ReadOnlySpan<char> sep, bool trimWhiteSpace = false)
		{
			_str = default;
			_separater = default;
			_trimWhiteSpace = false;
			Current = default;
		}

		public LineByCharEnumerator GetEnumerator()
		{
			return default;
		}

		public bool MoveNext()
		{
			return false;
		}

		public bool Contains(ReadOnlySpan<char> i_String)
		{
			return false;
		}
	}

	public readonly ref struct LineSplitEntry
	{
		public ReadOnlySpan<char> Line { get; }

		public ReadOnlySpan<char> Separator { get; }

		public bool _trimWhiteSpace { get; }

		public LineSplitEntry(ReadOnlySpan<char> line, ReadOnlySpan<char> separator, bool trimWhiteSpace = false)
		{
			Line = default;
			Separator = default;
			_trimWhiteSpace = false;
		}

		public void Deconstruct(out ReadOnlySpan<char> line, out ReadOnlySpan<char> separator)
		{
			line = default;
			separator = default;
		}

		public static implicit operator ReadOnlySpan<char>(LineSplitEntry entry)
		{
			return default;
		}
	}

	private static LineByCharEnumerator GetVectorEnumerator(string str)
	{
		return default;
	}

	public static bool TryParseVector2(this string str, out Vector2 vector)
	{
		vector = default;
		return false;
	}

	public static bool TryParseVector2Int(this string str, out Vector2Int vector)
	{
		vector = default;
		return false;
	}

	public static bool TryParseVector3(this string str, out Vector3 vector)
	{
		vector = default;
		return false;
	}

	public static bool TryParseVector3Int(this string str, out Vector3Int vector)
	{
		vector = default;
		return false;
	}

	public static bool TryParseVector4(this string str, out Vector4 vector)
	{
		vector = default;
		return false;
	}

	public static ReadOnlySpan<char> Trim(this ReadOnlySpan<char> str)
	{
		return default;
	}

	public static LineByCharEnumerator SplitByChar(this string str, ReadOnlySpan<char> sep, bool trimWhiteSpace = false)
	{
		return default;
	}
}
