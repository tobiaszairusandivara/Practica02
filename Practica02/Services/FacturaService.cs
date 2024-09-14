using Practica02.Data.Implementations;
using Practica02.Data.Interfaces;
using Practica02.Domain;

namespace Practica02Back.Services
{
    public class FacturaService : IFacturaService
    {
        private IAplication repository;
        public FacturaService()
        { 
           repository = new ArticulosRepository();
        }

        public bool CreateArt(Articulo oArticulo)
        {
            return repository.Create(oArticulo);
        }

        public List<Articulo> GetAllArt()
        {
            return repository.GetAll();
        }

        public bool DeleteArt(int id)
        {
            return repository.Delete(id);
        }

        public bool UpdateArt(int id, Articulo updArticulo)
        {
            return repository.Update(id, updArticulo);
        }
    }
}
