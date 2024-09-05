﻿using DesignPatterns.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns.RepositoryPattern
{
    public class BeerRepository : IBeerRepository
    { 
        private DesignPatternsContext _context;

        public BeerRepository(DesignPatternsContext context)
        {
            _context = context;
        }

        public void Add(Beer data) => _context.Beers.Add(data);

        public void Delete(int id)
        {
            var beer = _context.Beers.Find(id);
            _context.Beers.Remove(beer);
        }

        public IEnumerable<Beer> Get() => _context.Beers.ToList();

        public Beer Get(int id) => _context.Beers.Find(id);

        public void Update(Beer data) => _context.Entry(data).State = EntityState.Modified;

        public void Save() => _context.SaveChanges();
    }
}
