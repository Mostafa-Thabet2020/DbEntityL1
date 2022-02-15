using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbEntityL1.Models;
namespace DbEntityL1.Interfaces
{
    public interface ITeacherRepostory
    {
        void Add(Teachers obj);
        void Update(Teachers obj);
        void Delete(int Id);
        List<Teachers> Get();
        Teachers Get(int Id);
    }
}
