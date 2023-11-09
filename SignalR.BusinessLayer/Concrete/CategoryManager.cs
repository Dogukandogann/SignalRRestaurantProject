using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;

namespace SignalR.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void TAdd(Category entity)
        {
            _categoryDAL.Add(entity);
        }

        public void TDelete(Category entity)
        {
            _categoryDAL.Delete(entity);
        }

        public Category TGetByID(int id)
        {
            return _categoryDAL.GetByID(id);
        }

        public List<Category> TGetListAll()
        {
            return _categoryDAL.GetListAll();
        }

        public void TUpdate(Category entity)
        {
            _categoryDAL.Update(entity);
        }
    }
}
