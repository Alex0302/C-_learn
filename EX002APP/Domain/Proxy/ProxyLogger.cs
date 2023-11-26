using Logger;

namespace Proxy;

public class ProxyLogger
{
    private Ilogger logger;
    private Ilogger defaultLogger;

    public ProxyLogger(Ilogger defaultLogger, Ilogger logger)
    {
        this.logger = logger;
        this.defaultLogger = defaultLogger;
    }

    public ProxyLogger(Ilogger logger = null)
    : this(NullLogger.Instance, logger)
    {
    }
    public Ilogger GetIlogger()
    {
        if (this.logger == null)
        {
            this.logger = defaultLogger;
        }
        return this.logger;
    }

    internal Ilogger GetLogger()
    {
        if (this.logger == null)
        {
            this.logger = defaultLogger;
        }
        return this.logger;
    }
}