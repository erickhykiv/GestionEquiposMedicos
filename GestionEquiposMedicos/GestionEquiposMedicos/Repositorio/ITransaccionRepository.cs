﻿
using GestionEquiposMedicos.Modelos
namespace GestionEquiposMedicos.Repositorio


public interface ITransaccionRepository
{
    Task<List<Transaccion>> GetAllAsync();
    Task<Transaccion> GetByIdAsync(int id);
    Task AddAsync(Transaccion transaccion);
    Task UpdateAsync(Transaccion transaccion);
    Task DeleteAsync(int id);
}
