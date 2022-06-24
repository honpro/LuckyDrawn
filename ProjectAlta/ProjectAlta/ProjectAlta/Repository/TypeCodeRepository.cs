using Microsoft.EntityFrameworkCore;
using ProjectAlta.Context;

namespace ProjectAlta.Repository
{
    public class TypeCodeRepository : iTypeCodeRepository
    {
        private readonly AddContext addContext;

        public TypeCodeRepository(AddContext addcon)
        {
            addContext = addcon;
        }

        public void Delete(int TypeCodeID)
        {
           var  typeCode = addContext.TypeCodes.Find(TypeCodeID);
        }

        public IEnumerable<Entity.TypeCode> GetAll()
        {
           return addContext.TypeCodes.ToList();
        }

        public Entity.TypeCode GetById(int TypeCodeID)
        {
            return addContext.TypeCodes.Find(TypeCodeID);
        }

        public void Insert(Entity.TypeCode TypeCode)
        {
            addContext.TypeCodes.Add(TypeCode);
        }

        public void Save()
        {
            addContext.SaveChanges();
        }

        public void Update(Entity.TypeCode TypeCode)
        {
            ;
        }
    }
}
