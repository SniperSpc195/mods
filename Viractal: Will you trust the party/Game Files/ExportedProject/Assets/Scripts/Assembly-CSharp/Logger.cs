using System.Collections.Generic;

public class Logger : ILogger
{
	private Dictionary<string, ILogProc> mLogMap;

	~Logger()
	{
	}

	public void AddProc(string logName, ILogProc logProc)
	{
	}

	public void RemoveProc(string logName)
	{
	}

	public void LogStart()
	{
	}

	public void LogEnd()
	{
	}

	public void Logging(LogLevel.Level logLevel, string message)
	{
	}
}
