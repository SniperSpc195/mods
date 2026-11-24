public interface ILogger
{
	void LogStart();

	void LogEnd();

	void Logging(LogLevel.Level logLevel, string message);
}
