using Project.ENTITES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repositories.Abstracts
{
    public interface ICategoryRepository:IRepository<Category>
    {
        public void SpeacialCategoryCreation(Category category,params string[] productName);//Kategori eklendiğinde 


    }
}
