public abstract class LogProcInterface : ILogProc
{
	protected LogLevel mPriority;

	public LogProcInterface()
	{
	}

	~LogProcInterface()
	{
	}

	public abstract void Logging(LogLevel.Level logLevel, string message);

	public virtual void LogStart()
	{
	}

	public virtual void LogEnd()
	{
	}

	public void SetPriority(LogLevel.Level priority)
	{
	}

	public LogLevel.Level GetPriority()
	{
		return LogLevel.Level.Off;
	}
}
