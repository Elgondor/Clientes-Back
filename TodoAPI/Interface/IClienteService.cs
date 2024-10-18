

using TodoAPI.Contracts;
using TodoAPI.Models;

namespace TodoAPI.Interface
{
     public interface IClienteServices
    {
     Task<IEnumerable<Cliente>> GetAllAsync();
    //  Task<PaginatedList<Cliente>> GetAllAsync();
     
    }
}