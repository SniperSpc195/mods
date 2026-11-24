public interface ILogProc
{
	void LogStart();

	void LogEnd();

	void Logging(LogLevel.Level logLevel, string message);

	void SetPriority(LogLevel.Level priority);

	LogLevel.Level GetPriority();
}
