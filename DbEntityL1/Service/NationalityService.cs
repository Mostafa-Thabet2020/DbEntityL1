using DbEntityL1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbEntityL1.Service
{
    public class NationalityService
    {
        #region CRUD Actions
        EntityDbContext context = new EntityDbContext();

        public void Add(Nationality nationality)
        {
            if (!IsExist(nationality.Name))
            {
                nationality.CreatedDate = DateTime.Now;
                context.nationalities.Add(nationality);
                context.SaveChanges();
            }
        }
        //overload (polymorphism princple)
        public List<Nationality> Get()
        {
            return context.nationalities.ToList();
        }
        public Nationality Get(int NationalityId)
        {
            return context.nationalities.Find(NationalityId);
        }
        public void Update(Nationality nationality)
        {
            if (IsExist(nationality.Id))
            {
                Nationality oldNationality = Get(nationality.Id);
                oldNationality.Name = nationality.Name;
                context.nationalities.Update(oldNationality);
                context.SaveChanges();
            }
        }
        public void Delete(int Id)
        {
            if (IsExist(Id))
            {
                context.nationalities.Remove(Get(Id));
            }
        }
        /// <summary>
        /// is nationality exist by id
        /// </summary>
        public bool IsExist(int Id)
        {
            return context.nationalities.Any(x => x.Id == Id);
        }
        /// <summary>
        /// is nationality exist by name
        /// </summary>
        public bool IsExist(string Name)
        {
            return context.nationalities.Any(x => x.Name == Name);
        }
        #endregion
    }
}
