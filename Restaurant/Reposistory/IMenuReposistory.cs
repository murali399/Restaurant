using Microsoft.EntityFrameworkCore;
using Restaurant.Data;
using Restaurant.Models;

namespace Restaurant.Reposistory
{
    public class IMenuReposistory : IMenuInterface
    {
        private readonly MenuDbContext dbContext;

        public IMenuReposistory( MenuDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public  async Task<List<Menu>> GetAll()
        {
           return  await dbContext.menus.ToListAsync();
        }
        public async  Task<Menu> GetById(int id)
        {
            var data=await  dbContext.menus.FirstOrDefaultAsync(x => x.MenuId == id);
            return data;
            
               
        }


        public async  Task<Menu> Create(Menu menu)
        {  
            await dbContext.menus.AddAsync(menu);
            await dbContext.SaveChangesAsync();
            return menu;


        }


        
       
        public  async Task<Menu> Update(int id,Menu menu)
        {
            var data = dbContext.menus.FirstOrDefault(x => x.MenuId == id);
            if (data == null)
            {
                return null;

            }
            data.Price = menu.Price;
            data.MenuItemName = menu.MenuItemName;

            data.Description = menu.Description;
            data.PhotoUrl= menu.PhotoUrl;
            data.CategoryName = menu.CategoryName;
             await dbContext.SaveChangesAsync();
            return data;



        }
        public async Task<Menu> Delete(int id)
        {
            var data = dbContext.menus.FirstOrDefault(x => x.MenuId == id);
            if (data == null)
            {
                return null;

            }
            dbContext.menus.Remove(data);
            await dbContext.SaveChangesAsync();
            return data;

        }

    }
}
