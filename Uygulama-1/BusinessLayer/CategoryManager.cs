using Uygulama_1.Models;

namespace Uygulama_1.BusinessLayer
{
    public class CategoryManager
    {
        GenericRepository<Category> _repository = new GenericRepository<Category>();

        public void Create(Category category)
        {
            _repository.Create(category);
        }

        public List<Category> GetAll()
        {
            return _repository.GetAll();
        }

        public Category GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(Category category) 
        { 
            _repository.Update(category);
        }

        public void Delete(int id) 
        { 
            _repository.Delete(id);
        }
    }
}
