﻿using exercise.wwwapi.Models;

namespace exercise.wwwapi.Repository
{
    public interface IRepository<T, TKey> where T : class
    {
        List<T> GetAll();
        T Add(T entity);
        T GetOne(TKey firstname);
        T Update(TKey name, T updated);
        T Delete(TKey name);
        //Book Update(int id, Book entity);
    }

    //public interface IRepository<T> where T : class
    //{
    //    List<T> GetAll();
    //    T Add(T entity);
    //    T GetOne(string firstname);
    //    T Update(string name, string updateName);
    //    T Delete(string firstname);

    //}

}
