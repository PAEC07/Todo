using System;


namespace Todo
{
    public interface IReposetory<T> 
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        T Get(Guid id);
        


    }
}
