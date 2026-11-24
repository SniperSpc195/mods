using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class JsonNode : IEnumerable<JsonNode>, IEnumerable, IDisposable
{
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__14 : IEnumerator<JsonNode>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private JsonNode _003C_003E2__current;

		public JsonNode _003C_003E4__this;

		private IEnumerator _003C_003E7__wrap1;

		private IDictionaryEnumerator _003C_003E7__wrap2;

		JsonNode IEnumerator<JsonNode>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__14(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private object obj;

	public JsonNode this[int i] => null;

	public JsonNode this[string key] => null;

	public int Count => 0;

	public JsonNode(object obj)
	{
	}

	public void Dispose()
	{
	}

	public string Serialize(bool writeIndented = false)
	{
		return null;
	}

	public byte[] SerializeBin(bool zlib = false)
	{
		return null;
	}

	public static JsonNode ParseBin(byte[] bin, bool zlib = false)
	{
		return null;
	}

	public static JsonNode Parse(string json, bool removeComment = false)
	{
		return null;
	}

	public T Get<T>()
	{
		return default;
	}

	[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__14))]
	public IEnumerator<JsonNode> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public bool IsList()
	{
		return false;
	}

	public bool IsDictionary()
	{
		return false;
	}

	public List<string> GetKeys()
	{
		return null;
	}

	public bool KeyIsValid(string key)
	{
		return false;
	}

	public bool Contains(object key)
	{
		return false;
	}

	public bool IsJsonNode()
	{
		return false;
	}

	public bool IsArray()
	{
		return false;
	}

	public bool IsNull()
	{
		return false;
	}

	public bool IsNum()
	{
		return false;
	}

	public bool IsLong()
	{
		return false;
	}

	public bool IsDouble()
	{
		return false;
	}

	public bool IsBool()
	{
		return false;
	}

	public bool IsString()
	{
		return false;
	}

	public new Type GetType()
	{
		return null;
	}

	public T GetEnum<T>() where T : struct
	{
		return default;
	}

	public string GetString()
	{
		return null;
	}

	public bool GetBool()
	{
		return false;
	}

	public long GetInt64()
	{
		return 0L;
	}

	public ulong GetUInt64()
	{
		return 0uL;
	}

	public long GetLong()
	{
		return 0L;
	}

	public ulong GetUlong()
	{
		return 0uL;
	}

	public int GetIntHex()
	{
		return 0;
	}

	public int GetInt()
	{
		return 0;
	}

	public uint GetUint()
	{
		return 0u;
	}

	public float GetFloat()
	{
		return 0f;
	}

	public double GetDouble()
	{
		return 0.0;
	}

	public Vector3 GetVector3()
	{
		return default;
	}

	public Vector2 GetVector2()
	{
		return default;
	}

	public Vector3Int GetVector3Int()
	{
		return default;
	}

	public Vector2Int GetVector2Int()
	{
		return default;
	}

	public Dictionary<string, object> GetDictionary()
	{
		return null;
	}

	public List<object> GetArray()
	{
		return null;
	}

	public void Set(string key, JsonNode a)
	{
	}

	public void Set(string key, bool a)
	{
	}

	public void Set(string key, int a)
	{
	}

	public void Set(string key, float a)
	{
	}

	public void Set(string key, double a)
	{
	}

	public void Set(string key, long a)
	{
	}

	public void Set(string key, string a)
	{
	}

	public void Set(int i, JsonNode a)
	{
	}

	public void Set(int i, object a)
	{
	}

	public void Add(JsonNode a)
	{
	}

	public void RemoveAt(int i)
	{
	}

	public void Remove(string key)
	{
	}

	public void Sort()
	{
	}

	private static Dictionary<string, object> Sort(Dictionary<string, object> d)
	{
		return null;
	}
}
