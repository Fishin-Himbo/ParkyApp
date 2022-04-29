using ParkyAPI.Data;
using ParkyAPI.Models;
using ParkyAPI.Repository.IRepository;
using System.Collections.Generic;
using System.Linq;

namespace ParkyAPI.Repository
{
    public class NationalParkRepository : INationalParkRepository
    {
        // DbContext field is required to access the database
        private readonly AppDbContext _db;

        // Constructor gets the context using dependency injection
        public NationalParkRepository(AppDbContext db)
        {
            _db = db;
        }

        public bool CreateNationalPark(NationalPark nationalPark)
        {
            _db.NationalPark.Add(nationalPark);
            return SaveNationalPark();
        }

        public bool DeleteNationalPark(NationalPark nationalPark)
        {
            _db.NationalPark.Remove(nationalPark);
            return SaveNationalPark();
        }

        public NationalPark GetNationalPark(int nationalParkId)
        {
            return _db.NationalPark.FirstOrDefault(np => np.NationalParkId == nationalParkId);
        }

        public ICollection<NationalPark> GetNationalParks()
        {
            return _db.NationalPark.OrderBy(np => np.NationalParkName).ToList();
        }

        public bool NationalParkExists(string nationalParkName)
        {
            return _db.NationalPark.Any(np => np.NationalParkName.ToLower().Trim() == nationalParkName.ToLower().Trim());
        }

        public bool NationalParkExists(int nationalParkId)
        {
            return _db.NationalPark.Any(np => np.NationalParkId == nationalParkId);
        }

        public bool SaveNationalPark()
        {
            return _db.SaveChanges() >= 0; // SaveChanges returns an int - the # of rows written to the DB
        }

        public bool UpdateNationalPark(NationalPark nationalPark)
        {
            _db.NationalPark.Update(nationalPark);
            return SaveNationalPark();
        }
    }
}
