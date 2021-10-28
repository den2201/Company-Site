using My_company.Domain.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace My_company.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        Task<IQueryable<ServiceItem>> GetServiceItemsAsync();

        Task<ServiceItem> GetServiceItemByIdAsync(Guid id);
        Task SaveServiceItemAsync(ServiceItem serviceItem);
        Task DeleteServiceItemAsync(Guid id);
    }
}
