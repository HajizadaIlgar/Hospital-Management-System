using HospitalManagement.Core.Entities.Commons;
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
    public IQueryable<T> GetAll()
      => Table.AsQueryable();
    public async Task<T?> GetByIdAsync(int id)
            => await Table.FindAsync(id);

    public IQueryable<T> GetWhere(Func<T, bool> expression)
            => Table.Where(expression).AsQueryable();
    public async Task<bool> IsExistAsync(int id)
             => await Table.AnyAsync(x => x.Id == id);
    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
