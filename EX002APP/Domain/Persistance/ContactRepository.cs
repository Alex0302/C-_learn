using Model;

namespace Persistance;

public class Repository<T> : IRepository<T>
where T : Contact
{
    private List<T> storage;
    public Repository()
    {
        storage = new List<T>();
    }
    public void Append (T model)
    {
        this.storage.Add(model);
    }

    public T Get(int id)
    {
        foreach (var item in this.storage)
        {
            if (item.Id == id) return item;
        }
        return null;
    }

    public T[] GetAll()
    {
        return this.storage.ToArray();
    }

    public void Remove(int id)
    {
        int position = -1;
        
        for (int i = 0; i < this.storage.Count; i++)
        {
            if (this.storage[i].Id == id)
            {
                position = i;
                break;
            }
        }

        this.storage.RemoveAt(position);
    }

    public override string ToString()
    {
        string output = String.Empty;

        var contacts = this.GetAll();

        for (int i = 0; i < contacts.Length; i++)
        {
            output += $"{contacts[i]}\n";
        }

        return output;
    }

    public void Update(int id, T contact)
    {
        throw new NotImplementedException();
    }

}