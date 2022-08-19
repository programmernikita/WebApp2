
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp2.Models;

namespace WebApp2.Services
{
    public interface IRepo<T1, T2>
    {
        public Task<Customer> Add(Customer item);
        public Task<ICollection<Customer>> GetAll();
        public Task<Customer> GetT(int id);
        public Task<Customer> Update(Customer item);

    }
}