using DulceFacil.Dominio.Modelo.Abstracciones;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulce.Facil.Infraestructura.AccesoDatos.Repositorio
{
    public class RepositorioImpl<T> : IRepositorio<T> where T : class


    {

        private readonly Sistema_PedidosContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public RepositorioImpl(Sistema_PedidosContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public async Task AddAsync(T entidad)
        {
            try
            {
                await _dbSet.AddAsync(entidad); // inset todas las tablas
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Error': no se pudo insertar datos," + ex.Message);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {   
                var entidad= await GetByIdAsync(id);
                _dbSet.Remove(entidad); // eliminar todas las tablas
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Error': no se pudo eliminar datos," + ex.Message);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync(); // inset todas las tablas
                
            }
            catch (Exception ex)
            {

                throw new Exception("Error': no se pudo listar datos," + ex.Message);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {

                throw new Exception("Error': no se pudo recuperar datos," + ex.Message);
            }
        }

        public async Task UpdateAsync(T entidad)
        {
            try
            {
                _dbSet.Update(entidad);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw new Exception("Error': no se pudo actualizar datos," + ex.Message);
            }
        }
    }
}
