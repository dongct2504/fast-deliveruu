using FastDeliveruu.Domain.Entities;
using FastDeliveruu.Domain.Interfaces;
using FastDeliveruu.Infrastructure.Data;

namespace FastDeliveruu.Infrastructure.Repositories;

public class MenuItemRepository : Repository<MenuItem>, IMenuItemRepository
{
    public MenuItemRepository(FastdeliveruuContext context) : base(context)
    {
    }

    public Task UpdateMenuItem(MenuItem menuItem)
    {
        throw new NotImplementedException();
    }
}