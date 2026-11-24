using System;
using System.Collections.Generic;
using UnityEngine;

namespace StUtility
{
	internal class CString
	{
		public static string EncodeBase64(byte[] i_ByteData)
		{
			return null;
		}

		public static byte[] DecodeBase64(string i_Text)
		{
			return null;
		}

		public static string EncodeByteToUtf8(byte[] i_Buffer)
		{
			return null;
		}

		public static byte[] EncodeUtf8ToByte(string i_String)
		{
			return null;
		}

		public static string EncodeByteToUtf8(byte[] i_Buffer, int i_Offset)
		{
			return null;
		}

		public static string EncodeByteToUtf8(byte[] i_Buffer, int i_Offset, ref int i_Size)
		{
			return null;
		}

		public static string ChangeCommaNumber(int i_Number)
		{
			return null;
		}

		public static string ChangeCommaNumberL(long i_Number)
		{
			return null;
		}

		public static string RemoveCRLF(string i_Str)
		{
			return null;
		}

		public static bool CheckAllSpace(string i_Str)
		{
			return false;
		}

		public static string TagEscapeRemove(string i_Str)
		{
			return null;
		}

		public static string TagEscape(string i_Str)
		{
			return null;
		}

		public static string Han2Zen(string i_Str)
		{
			return null;
		}

		public static ReadOnlySpan<char> GetFileNameWithoutExtension(ReadOnlySpan<char> i_Src)
		{
			return default;
		}

		public static List<string> MakeRangeSpecification(string text)
		{
			return null;
		}

		public static string SandwichColor(string a, TextColor color)
		{
			return null;
		}

		public static bool TryGetColor(string i_HexString, out Color o_Color)
		{
			o_Color = default;
			return false;
		}
	}
}
