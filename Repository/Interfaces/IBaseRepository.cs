﻿namespace Repository;

public interface IBaseRepository<T> where T : class
{
    public Task SaveAsync(T entity);
    public Task<bool> DeleteAsync(T entity);
    public Task<bool> UpdateAsync(T entity);
    public Task<List<T>> GetAllAsync();
    public Task<T?> GetSingle(Guid guid);
}