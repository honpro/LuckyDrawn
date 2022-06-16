
using ProjectAlta.Entity;

namespace ProjectAlta.Repository
{
    public interface iTypeCodeRepository
    {
        IEnumerable<Entity.TypeCode> GetAll();
        Entity.TypeCode GetById(int TypeCodeID);
        void Insert(Entity.TypeCode TypeCode);
        void Update(Entity.TypeCode TypeCode);
        void Delete(int TypeCodeID);
        void Save();
    }
}
