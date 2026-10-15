using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class GenericStore<T> where T : class, IHasId
    {
        List<T> _repo;

        public GenericStore(List<T> repo)
        {
            _repo = repo;
        }

        public void Add(T item)
        {
            if (item is not null)
            {
                _repo.Add(item);
            }
        }

        public T GetById(int id)
        {
            foreach (var item in _repo)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }


        public List<T> GetALlStudents() => _repo;


        public void Remove(int id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _repo.Remove(item);
            }


        }
    }
}
