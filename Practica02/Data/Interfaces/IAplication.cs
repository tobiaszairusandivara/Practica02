﻿using Microsoft.AspNetCore.Components.Forms;
using Practica02.Domain;

namespace Practica02.Data.Interfaces
{
    public interface IAplication
    {
        bool Create(Articulo oArticulo);//se hace todo o no se hace nada
        List<Articulo> GetAll();
        bool Delete(int id);
        bool Update(int id, Articulo updArticulo);//Articulo oArticulo
    }
}