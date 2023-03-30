using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspcoreapi.Models;

namespace aspcoreapi.Repositories
{
    public interface IEmprole
    {
        Task<IEnumerable<Emprole>> GetEmprole();
        Task<Emprole> GetEmproleByID(int ID);
        Task<Emprole> InsertEmprole();
        Task<Emprole> UpdateEmprole();

        bool DeleteEmprole(int ID);
    }
}
