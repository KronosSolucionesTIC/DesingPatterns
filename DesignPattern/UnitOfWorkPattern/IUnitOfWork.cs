using DesignPatterns.Models;
using DesignPatterns.RepositoryPattern;

namespace DesignPatterns.UnitOfWorkPattern
{
    public interface IUnitOfWork
    {
        public IRepository<Beer> Beers { get; }
        public IRepository<Brand> Brands { get; }
        public void Save();
    }
}
