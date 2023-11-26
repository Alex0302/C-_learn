using Model;
using Persistance;
using Logger;
using Proxy;

namespace Cache;

public class CacheService<T>
{
    private Dictionary<int, T> dic;
    private IRepository<T> repository;
    private Ilogger logger;
    public CacheService(IRepository<T> repository, Ilogger logger = null)
    {
        this.dic = new();
        this.repository = repository;
        this.logger = new ProxyLogger(logger).GetLogger();
    }

    public T Get(int id)
    {
        this.logger.Log("попытка обращения к методу CacheService public T Get(int id)");
        if (!this.dic.ContainsKey(id))
        {
            T contact = this.repository.Get(id);
            this.dic.Add(id, contact);
        }
        return this.dic[id];
    }
}