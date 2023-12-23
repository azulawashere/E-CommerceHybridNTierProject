using AutoMapper;
using Project.BLL.DTOClasses;
using Project.BLL.Handlers.ExpressionHandlers;
using Project.BLL.ManagerServices.Abstracts;
using Project.DAL.Repositories.Abstracts;
using Project.ENTITES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.ManagerServices.Concretes
{
    public class BaseManager<T, U> : IManager<T, U> where T : BaseDTO where U : class, IEntity
    {
        protected readonly IRepository<U> _iRep;
        protected readonly IMapper _mapper;
        public BaseManager(IRepository<U> iRep, IMapper mapper)
        {
            _mapper = mapper;
            _iRep = iRep;

        }
        public string Add(T item)
        {
            //SaatEkle(DTO)
            SaatEkle(item);

            //Mapping => DTO

            _iRep.Add(TMapingToU(item));
            return "Ekleme basarılıdır";



        }
        private U TMapingToU(T item)
        {
            U entity = _mapper.Map<U>(item); return entity;
        }
        private T UMapingToT(U item)
        {
            T entity = _mapper.Map<T>(item); return entity;
        }
        private void SaatEkle(T item)
        {
            U entity = TMapingToU(item);
            entity.CreatedDate = entity.CreatedDate.AddHours(3);
        }

        public async Task AddAsync(T item)
        {
            SaatEkle(item);

            await _iRep.AddAsync(TMapingToU(item));


        }

        bool ElemanKontrol(List<T> list)
        {

            if (list.Count > 5) return false;
            return true;

        }


        public string AddRange(List<T> list)
        {
            List<U> listU = new();
            if (ElemanKontrol(list)) return "Maksimum 5 veri ekleyebileceginiz icin islem gercekleştirelemedi";
            foreach (T item in list)
            {

                listU.Add(TMapingToU(item));
            }
            _iRep.AddRange(listU);
            return "Ekleme basarılı bir şekilde gercekleşti";
        }

        public async Task<string> AddRangeAsync(List<T> list)
        {
            List<U> listU = new();
            if (ElemanKontrol(list)) return "Maksimum 5 veri ekleyebileceginiz icin islem gercekleştirelemedi";
            foreach (T item in list)
            {

                listU.Add(TMapingToU(item));
            }
            await _iRep.AddRangeAsync(listU);
            return "Ekleme basarılıdır";
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {

            //Exp kontrol islemleri
            return _iRep.Any(ExpressionVisitorHelper.ReplaceVisitor<T, U>(exp));
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            return await _iRep.AnyAsync(ExpressionVisitorHelper.ReplaceVisitor<T, U>(exp));
        }

        public void Delete(T item)
        {
         

            _iRep.Delete(TMapingToU(item));
        }

        public void DeleteRange(List<T> list)
        {

            _iRep.DeleteRange(TListMappingToUList(list));
        }

        private List<U> TListMappingToUList(List<T> list)
        {
            List<U> listU = new();
            foreach (T item in list)
            {
                TMapingToU(item);
            }

            return listU;
        }

        public string Destroy(T item)
        {

            if (item.Status == ENTITES.Enums.DataStatus.Deleted)
            {
                _iRep.Destroy(TMapingToU(item));
                return "Veri basarıyla yok edildi";
            }

            return $"Veriyi silemezsiniz cünkü {item.ID} {item.Status}   pasif degil";

        }

        public string DestroyRange(List<T> list)
        {

            foreach (T item in list) return Destroy(item);

            return "Silme işleminde sorunla karsılasıldı lütfen veri durumunun pasif oldugundan emin olunuz";

        }

        public async Task<T> FindAsync(int id)
        {
            return UMapingToT(await _iRep.FindAsync(id));
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {

            return _mapper.Map<T>(_iRep.FirstOrDefault(ExpressionVisitorHelper.ReplaceVisitor<T, U>(exp)));
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp)
        {
            return UMapingToT(await _iRep.FirstOrDefaultAsync(ExpressionVisitorHelper.ReplaceVisitor<T, U>(exp)));
        }

        private List<T> ListUMappingToListT(List<U> list)
        {
            List<T> result = new();
            foreach (U item in list)
            {
                result.Add(UMapingToT(item));
            }
            return result;
        }
        public List<T> GetActives()
        {
            return ListUMappingToListT(_iRep.GetActives());
        }

        public async Task<List<T>> GetActivesAsync()
        {
            return ListUMappingToListT(await _iRep.GetActivesAsync());
        }

        public List<T> GetAll()
        {
            return ListUMappingToListT(_iRep.GetAll());
        }

        public List<T> GetFirstDatas(int count)
        {
            return ListUMappingToListT(_iRep.GetFirstDatas(count));
        }

        public List<T> GetLastDatas(int count)
        {
            return ListUMappingToListT(_iRep.GetLastDatas(count));
        }

        public List<T> GetModifieds()
        {
            return ListUMappingToListT(_iRep.GetModifieds());
        }

        public List<T> GetPassives()
        {
            return ListUMappingToListT(_iRep.GetPassives());
        }

        public object Select(Expression<Func<T, object>> exp)
        {
            return _iRep.Select(ExpressionVisitorHelper.ReplaceVisitor<T, U>(exp));
        }

        public IQueryable<X> Select<X>(Expression<Func<T, X>> exp)
        {
            return _iRep.Select(ExpressionVisitorHelper.ReplaceVisitor<T, U, X>(exp));

        }

        public async Task UpdateAsync(T item)
        {
            await _iRep.UpdateAsync(TMapingToU(item));
        }

        public async Task UpdateRangeAsync(List<T> list)
        {
            await _iRep.UpdateRangeAsync(TListMappingToUList(list));
        }

        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return ListUMappingToListT(_iRep.Where(ExpressionVisitorHelper.ReplaceVisitor<T, U>(exp)));
        }
    }
}
