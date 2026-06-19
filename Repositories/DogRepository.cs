using Microsoft.EntityFrameworkCore;
using ShelterApi.Data;
using ShelterApi.Interfaces;
using ShelterApi.Models;

namespace ShelterApi.Repositories;

public class DogRepository : IRepository<Dog>
{
    private readonly AppDbContext _db;
    public DogRepository(AppDbContext db) { _db = db; }

    public async Task<IEnumerable<Dog>> GetAllAsync() =>
        await _db.Dogs.ToListAsync();

    public async Task<Dog?> GetByIdAsync(int id) =>
        await _db.Dogs.FindAsync(id);

    public async Task AddAsync(Dog entity) {
        await _db.Dogs.AddAsync(entity);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(Dog entity) {
        _db.Dogs.Update(entity);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id) {
        var dog = await GetByIdAsync(id);
        if (dog != null) { _db.Dogs.Remove(dog); await _db.SaveChangesAsync(); }
    }
}