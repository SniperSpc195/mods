using System.Collections.Generic;

public interface IDatabase<TData> where TData : IMasterData
{
	TData[] DataArray { get; set; }

	Dictionary<string, TData> Dictionary { get; }

	TData GetCachedData(string i_ID)
	{
		return default;
	}
}
