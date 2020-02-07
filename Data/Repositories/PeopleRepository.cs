using System;
using System.Threading.Tasks;
using demo.Request;

namespace demo.Data.Repositories
{
    public class PeopleRepository : IPeopleRepository
    {
        protected readonly IGenericRepository _db;

        public PeopleRepository(IGenericRepository db)
        {
            _db = db ?? throw new
                ArgumentException(nameof(db));
        }

        public async Task<Models.People> GetById(PeopleByIdRequest R)
        {
            return await _db.GetAsync<Models.People>("SELECT Id, Name, Gender FROM [dbo].People WHERE Id = @Id;", R);
        }
    }
}
