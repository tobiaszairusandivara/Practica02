using Practica02.Domain;

namespace Practica02Back.Services
{
    public interface IFacturaService
    {
        bool CreateArt(Articulo oArticulo);
        List<Articulo> GetAllArt();
        bool DeleteArt(int id);
        bool UpdateArt(int id, Articulo updArticulo);//Articulo oArticulo
    }
}
