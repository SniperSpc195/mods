public class LogLevel
{
	public enum Level
	{
		Off = 0,
		Fatal = 1,
		Alert = 2,
		Critical = 3,
		Error = 4,
		Warning = 5,
		Notice = 6,
		Info = 7,
		Debug = 8,
		All = 9
	}

	private Level mLogLevelValue;

	public Level LogLevelValue
	{
		get
		{
			return Level.Off;
		}
		set
		{
		}
	}

	public LogLevel()
	{
	}

	public LogLevel(Level logLevelValue)
	{
	}

	~LogLevel()
	{
	}

	public static string LogLevelToStr(Level logLevel)
	{
		return null;
	}
}
