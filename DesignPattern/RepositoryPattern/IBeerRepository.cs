using DesignPatterns.Models;

namespace DesignPatterns.RepositoryPattern
{
    public interface IBeerRepository
    {
        IEnumerable<Beer> Get();
        Beer Get(int id);
        void Add(Beer data);
        void Update(Beer data);
        void Delete(int id);
        void Save();
    }
}
