using System;
using Cysharp.Text;

public static class ZStringExtension
{
	public static void AppendReplace(this ref Utf16ValueStringBuilder sb, ReadOnlySpan<char> inputText, ReadOnlySpan<char> patternText, ReadOnlySpan<char> replaceText)
	{
	}

	public static void AppendReplace(this ref Utf16ValueStringBuilder sb, ReadOnlySpan<char> patternText, ReadOnlySpan<char> replaceText)
	{
	}
}
