using Insurance.Data.Common;
using Insurance.Data.Repositories;
using Insurance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepository;
        public CategoryService(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(Category entity)
        {
            _categoryRepository.Add(entity);
        }

        public void DeleteCategory(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void UpdateCategory(Category entity)
        {
            _categoryRepository.Update(entity);
        }
    }

    public interface ICategoryService
    {
        void AddCategory(Category entity);
        void UpdateCategory(Category entity);
        void DeleteCategory(Category entity);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategories();
    }
}
