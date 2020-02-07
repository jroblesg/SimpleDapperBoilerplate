using System.Threading.Tasks;
using demo.Request;

namespace demo.Data.Repositories
{
    public interface IPeopleRepository
    {
        Task<Models.People> GetById(PeopleByIdRequest R);
    }
}