using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class LocationRepository : ILocationRepository
    {
        private readonly DataContext _context;
        public LocationRepository(DataContext context){
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public Task<Location> GetLocation(int id)
        {
            var Location = _context.Locations.Include(l => l.Flights).FirstOrDefaultAsync(f=> f.Id == id);
            return Location;
        }

        public async Task<IEnumerable<Location>> GetLocations()
        {
            try{
                var Locations = await _context.Locations.ToListAsync();
            return Locations;
            }
            catch(Exception ex) {
                return new List<Location>();
            }
            
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}