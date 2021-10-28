using Microsoft.EntityFrameworkCore;
using My_company.Domain.Entities;
using My_company.Domain.Repositories.Abstract;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace My_company.Domain.Repositories
{
    public class ServiceItemsRepository : IServiceItemsRepository
    {
        private readonly AppDbContext _appDbContext;

        public ServiceItemsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task DeleteServiceItemAsync(Guid id)
        {
            _appDbContext.ServiceItems.Remove(new ServiceItem { Id = id });
            await _appDbContext.SaveChangesAsync(); 
        }

        public async Task<ServiceItem> GetServiceItemByIdAsync(Guid id)
        {
            return await _appDbContext.ServiceItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IQueryable<ServiceItem>> GetServiceItemsAsync()
        {
            return _appDbContext.ServiceItems;
        }

        public async Task SaveServiceItemAsync(ServiceItem serviceItem)
        {
            if(serviceItem == default)
            {
                _appDbContext.Entry(serviceItem).State = EntityState.Added;
            }
            else
            {
                _appDbContext.Entry(serviceItem).State = EntityState.Modified;
            }
            await _appDbContext.SaveChangesAsync();
        }
    }
}
