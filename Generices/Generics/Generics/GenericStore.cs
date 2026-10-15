using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class GenericStore<T> where T : class, IHasId
    {
        Dictionary<int,T> _repo;

        public GenericStore(Dictionary<int, T> repo)
        {
            _repo = repo;
        }

        public void Add(T item)
        {
            if (_repo.ContainsKey(item.Id))
            {
                throw new InvalidOperationException($"An item with Id '{item.Id}' already exists.");
            }
            if (item is not null)
            {
                _repo.TryAdd(item.Id,item);
            }
        }

        public T GetById(int id)
        {
            _repo.TryGetValue(id, out T value);
            return value;
        }


        public IReadOnlyDictionary<int, T> GetAll() => _repo;


        public void Remove(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _repo.Remove(id);
            }


        }
    }
}
