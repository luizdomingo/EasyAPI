﻿using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.PontoVenda;
using Domain.Interfaces.Repository.PontoVenda;
using Microsoft.EntityFrameworkCore;

namespace Data.Implementations.PontoVenda
{
    public class PontoVendaImplementacao : BaseRepository<PontoVendaEntity>, IPontoVendaRepository
    {
        private readonly DbSet<PontoVendaEntity> _dbSet;

        public PontoVendaImplementacao(MyContext context) : base(context)
        {
            _dbSet = context.Set<PontoVendaEntity>();
            _dbSet.AsNoTracking();
        }
        public async Task<IEnumerable<PontoVendaEntity>> GetPdvs()
        {
            IQueryable<PontoVendaEntity> query = _dbSet;

            query = Includes(query);

            PontoVendaEntity[] result = await query.ToArrayAsync();
            return result;
        }
        public async Task<PontoVendaEntity> GetByIdPdv(Guid pdvId)
        {
            IQueryable<PontoVendaEntity> query = _dbSet;

            query = Includes(query);

            query = query.Where(pdv => pdv.Id.Equals(pdvId));

            PontoVendaEntity? result = await query.FirstOrDefaultAsync();
            return result;
        }

        public async Task<IEnumerable<PontoVendaEntity>> GetByIdPerfilUsuario(Guid IdPerfilUtilizarPDV)
        {
            IQueryable<PontoVendaEntity> query = _dbSet;

            query = Includes(query);

            query = query.Where(pdv => pdv.IdPerfilUtilizarPDV.Equals(IdPerfilUtilizarPDV));

            PontoVendaEntity[] result = await query.ToArrayAsync();
            return result;
        }

        public async Task<IEnumerable<PontoVendaEntity>> AbertosFechados(bool abertoFechado)
        {
            IQueryable<PontoVendaEntity> query = _dbSet;

            query = Includes(query);

            query = query.Where(pdv => pdv.AbertoFechado == abertoFechado);

            PontoVendaEntity[] result = await query.ToArrayAsync();
            return result;
        }

        private IQueryable<PontoVendaEntity> Includes(IQueryable<PontoVendaEntity> query)
        {

            query = query.Include(userAbriu => userAbriu.PerfilUsuarioEntityAbrilPDV)
                         .Include(userPDV => userPDV.PerfilUsuarioEntityUtilizarPDV)
                         .Include(periodo => periodo.PeriodoPontoVendaEntity);


            return query;
        }
    }
}