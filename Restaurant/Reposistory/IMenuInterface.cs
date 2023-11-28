using Restaurant.Models;

namespace Restaurant.Reposistory
{
    public interface IMenuInterface
    {
        Task<List<Menu>> GetAll();
        Task<Menu> GetById(int id);
        Task<Menu> Create(Menu  menu);
        Task<Menu> Update(int id,Menu menu);
        Task<Menu> Delete(int id);

    }
}
