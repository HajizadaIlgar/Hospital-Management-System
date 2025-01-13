﻿using HospitalManagement.Core.Entities.Common;
using HospitalManagement.Core.Repositories;
using HospitalManagement.DAL.Contexts;
using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.DAL.Repositories;
public class GenericRepository<T>(HospitalManagementDbContext _context) : IGenericRepository<T> where T : BaseEntity, new()
{

    protected DbSet<T> Table = _context.Set<T>();
    public async Task AddAsync(T entity)
    {
        await Table.AddAsync(entity);
    }

    public void Delete(T entity)
    {
        Table.Remove(entity);
    }

    public async Task DeleteAsync(int id)
    {
        await Table.Where(x => x.Id == id).ExecuteDeleteAsync();
        //T? entity = await GetByIdAsync(id);
        //Delete(entity!);
    }
    List<T> IGenericRepository<T>.GetAll()
     => Table.ToList();
    public async Task<T?> GetByIdAsync(int id)
            => await Table.FindAsync(id);

    public Task<IEnumerable<T>> GetPaginatedAllAsync(int take, int page)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetWhere(Func<T, bool> expression)
            => Table.Where(expression).AsQueryable();

    public async Task<bool> IsExistAsync(int id)
             => await Table.AnyAsync(x => x.Id == id);
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
