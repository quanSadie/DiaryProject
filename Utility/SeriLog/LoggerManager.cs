using Serilog;

namespace Utility;

public static class LoggerManager
{
    private static ILogger logger;

    static LoggerManager()
    {
        logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.Console()
            .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day,
                outputTemplate: "[{Timestamp:HH:mm:ss} {Level}] {Message}{NewLine}{Exception}")
            .CreateLogger();
    }

    public static void Info(string message)
    {
        logger.Information(message);
    }

    public static void Warn(string message)
    {
        logger.Warning(message);
    }

    public static void Error(string message, Exception? ex = null)
    {
        if (ex == null)
        {
            logger.Error(message);
        }
        else
        {
            logger.Error(message, ex);
        }
    }

    public static void Debug(string message)
    {
        logger.Debug(message);
    }

    public static void Fatal(string message, Exception? ex = null)
    {
        if (ex == null)
        {
            logger.Fatal(message);
        }
        else
        {
            logger.Fatal(message, ex);
        }
    }
}