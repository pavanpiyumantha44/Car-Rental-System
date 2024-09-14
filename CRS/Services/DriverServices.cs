using CRS.Data;
using CRS.Models;
using Microsoft.EntityFrameworkCore;

namespace CRS.Services
{
    public class DriverServices
    {
        private readonly ApplicationDbContext _context;

        public DriverServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Driver>> GetAllDriversAsync()
        {
            return await _context.Drivers.ToListAsync();
        }
        public async Task<Driver> GetDriverByIdAsync(int Id)
        {
            Driver driver = await _context.Drivers.FirstOrDefaultAsync(c => c.Id.Equals(Id));
            return driver;
        }
        public async Task<bool> InsertDriverAsync(Driver driver)
        {
            await _context.Drivers.AddAsync(driver);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateDriverAsync(Driver driver)
        {
            _context.Update(driver);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteDriverAsync(Driver driver)
        {
            _context.Remove(driver);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
