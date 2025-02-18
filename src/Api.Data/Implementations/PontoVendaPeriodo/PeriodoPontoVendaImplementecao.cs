﻿using Api.Data.Context;
using Api.Data.Repository;
using Domain.Entities.PontoVendaPeriodoVenda;
using Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Data.Implementations.PontoVendaPeriodo
{
    public class PeriodoPontoVendaImplementecao : BaseRepository<PeriodoPontoVendaEntity>, IPeriodoPontoVendaRepository
    {
        private readonly DbSet<PeriodoPontoVendaEntity> _dataset;
        public PeriodoPontoVendaImplementecao(MyContext context) : base(context)
        {
            _dataset = context.Set<PeriodoPontoVendaEntity>();
            _dataset.AsNoTracking();
        }
        public async Task<IEnumerable<PeriodoPontoVendaEntity>> Get(string descricao)
        {
            try
            {
                IQueryable<PeriodoPontoVendaEntity> query = _dataset;


                query = query.Where(p => p.DescricaoPeriodo.Contains(descricao));

                PeriodoPontoVendaEntity[] entites = await query.ToArrayAsync();

                return entites;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
