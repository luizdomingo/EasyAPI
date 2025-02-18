﻿using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities.Pedido;
using Domain.Interfaces.Repository.Pedido;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace Data.Implementations.Pedido
{
    public class PedidoImplementacao : BaseRepository<PedidoEntity>, IPedidoRepository
    {
        private readonly DbSet<PedidoEntity> _dtSet;
        public PedidoImplementacao(MyContext context) : base(context)
        {
            _dtSet = context.Set<PedidoEntity>();
            _dtSet.AsNoTracking();
        }
        public async Task<IEnumerable<PedidoEntity>> GetAll()
        {
            try
            {
                IQueryable<PedidoEntity> query = _dtSet;

                query = Includes(query);

                //query = query.Where();

                var entities = await query.ToArrayAsync();

                return entities;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<PedidoEntity> Get(Guid idPedido)
        {
            try
            {
                IQueryable<PedidoEntity> query = _dtSet;

                query = Includes(query);

                query = query.Where(ped => ped.Id.Equals(idPedido));

                var entity = await query.FirstOrDefaultAsync();

                return entity;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        public async Task<IEnumerable<PedidoEntity>> GetAll(Expression<Func<PedidoEntity, bool>> funcao, bool inlude = true)
        {
            try
            {
                IQueryable<PedidoEntity> query = _dtSet;

                query = Includes(query);

                query = query.Where(funcao);

                var entities = await query.ToArrayAsync();

                return entities;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<PedidoEntity>> GetAll(Guid idPdv)
        {
            try
            {
                IQueryable<PedidoEntity> query = _dtSet;

                query = Includes(query);

                //traz os pedidos cancelados tbm
                query = query.Where(pedido => pedido.PontoVendaEntityId.Equals(idPdv));

                var entities = await query.ToArrayAsync();

                return entities;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<PedidoEntity>> GetAllByCategoriaPreco(Guid idPdv, Guid idCategoriaPreco)
        {
            try
            {
                IQueryable<PedidoEntity> query = _dtSet;

                query = Includes(query);

                query = query.Where
                    (pedido => pedido.PontoVendaEntityId.Equals(idPdv)
                    && pedido.CategoriaPrecoEntityId.Equals(idCategoriaPreco));

                var entities = await query.ToArrayAsync();

                return entities;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<PedidoEntity>> GetAllBySituacao(Guid idPdv, Guid idSituacao)
        {
            try
            {
                IQueryable<PedidoEntity> query = _dtSet;

                query = Includes(query);

                query = query.Where
                    (pedido => pedido.PontoVendaEntityId.Equals(idPdv)
                    && pedido.SituacaoPedidoEntityId.Equals(idSituacao));

                var entities = await query.ToArrayAsync();

                return entities;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task<IEnumerable<PedidoEntity>> GetAllByUser(Guid idPdv, Guid idUserCreatePedido)
        {
            try
            {
                IQueryable<PedidoEntity> query = _dtSet;

                query = Includes(query);

                query = query.Where
                    (pedido => pedido.PontoVendaEntityId.Equals(idPdv)
                    && pedido.UserCreatePedidoId.Equals(idUserCreatePedido));

                var entities = await query.ToArrayAsync();

                return entities;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private static IQueryable<PedidoEntity> Includes(IQueryable<PedidoEntity> query)
        {
            //situacao pedido
            query = query.Include(sit => sit.SituacaoPedidoEntity);

            //usuario registo
            query = query.Include(perfil_user => perfil_user.UserCreatePedido);

            //categoria preco
            query = query.Include(cat_preco => cat_preco.CategoriaPrecoEntity);

            //pdv
            query = query.Include(pdv => pdv.PontoVendaEntity).ThenInclude(per => per.PeriodoPontoVendaEntity); ;


            //itens do pedido
            query = query.Include(itens => itens.ItensPedidoEntities).ThenInclude(prod => prod.ProdutoEntity).ThenInclude(per => per.CategoriaProdutoEntity);

            query = query.Include(itens => itens.ItensPedidoEntities).ThenInclude(prod => prod.ProdutoEntity).ThenInclude(per => per.ProdutoMedidaEntity);


            query = query.Include(itens => itens.ItensPedidoEntities).ThenInclude(prod => prod.ProdutoEntity).ThenInclude(per => per.ProdutoTipoEntity);



            return query;
        }


    }
}
