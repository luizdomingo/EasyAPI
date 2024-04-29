﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20240428231642_AlterPerfilUsuario")]
    partial class AlterPerfilUsuario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Domain.Entities.CategoriaPreco.CategoriaPrecoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoCategoria")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoCategoria")
                        .IsUnique();

                    b.ToTable("CategoriasPrecos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("710bd8dd-1853-43a1-8708-ca1f259d71ad"),
                            CreateAt = new DateTime(2024, 4, 28, 20, 16, 42, 500, DateTimeKind.Local).AddTicks(741),
                            DescricaoCategoria = "Balcão",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 20, 16, 42, 500, DateTimeKind.Local).AddTicks(750)
                        },
                        new
                        {
                            Id = new Guid("5533b87c-72d5-4033-85c4-ae44f5a3210c"),
                            CreateAt = new DateTime(2024, 4, 28, 20, 16, 42, 500, DateTimeKind.Local).AddTicks(754),
                            DescricaoCategoria = "IFood",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 20, 16, 42, 500, DateTimeKind.Local).AddTicks(756)
                        },
                        new
                        {
                            Id = new Guid("ed65a4e3-a0b0-40a7-b7ae-3397a965d924"),
                            CreateAt = new DateTime(2024, 4, 28, 20, 16, 42, 500, DateTimeKind.Local).AddTicks(758),
                            DescricaoCategoria = "Lojista",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 20, 16, 42, 500, DateTimeKind.Local).AddTicks(759)
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.PrecoProduto.PrecoProdutoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CategoriaPrecoEntityId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("PrecoProduto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProdutoEntityId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaPrecoEntityId");

                    b.HasIndex("ProdutoEntityId");

                    b.ToTable("PrecosProdutos", (string)null);
                });

            modelBuilder.Entity("Api.Domain.Entities.ProdutoMedida.ProdutoMedidaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("Descricao")
                        .IsUnique();

                    b.ToTable("ProdutosMedidas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("414a646f-1146-4b6d-bbfc-39a26e74a091"),
                            CreateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(2048),
                            Descricao = "Unidade",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(2047)
                        },
                        new
                        {
                            Id = new Guid("2f943e86-f06f-4f7d-babf-48d0d2d8f3ac"),
                            CreateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(2054),
                            Descricao = "Caixa",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(2054)
                        });
                });

            modelBuilder.Entity("Domain.Entities.CategoriaProduto.CategoriaProdutoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoCategoria")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("varchar(80)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoCategoria")
                        .IsUnique();

                    b.ToTable("CategoriasProdutos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("a9b05f16-71f0-4f77-a653-52c1a15b36bc"),
                            CreateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(97),
                            DescricaoCategoria = "Executivos",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(93)
                        },
                        new
                        {
                            Id = new Guid("d9d229c4-9a64-4836-af41-2f111f229c46"),
                            CreateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(125),
                            DescricaoCategoria = "Bebidas",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(123)
                        });
                });

            modelBuilder.Entity("Domain.Entities.PontoVendaPeriodoVenda.PeriodoPontoVendaEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoPeriodo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoPeriodo")
                        .IsUnique();

                    b.ToTable("PeriodosPontosVendas", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("567906bb-6eb4-42e9-b890-10e6da214766"),
                            CreateAt = new DateTime(2024, 4, 28, 20, 16, 42, 499, DateTimeKind.Local).AddTicks(9696),
                            DescricaoPeriodo = "Almoço",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 20, 16, 42, 499, DateTimeKind.Local).AddTicks(9700)
                        },
                        new
                        {
                            Id = new Guid("fc6a5d67-8356-4270-b9e6-7749b553dcf3"),
                            CreateAt = new DateTime(2024, 4, 28, 20, 16, 42, 499, DateTimeKind.Local).AddTicks(9703),
                            DescricaoPeriodo = "Janta",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 20, 16, 42, 499, DateTimeKind.Local).AddTicks(9704)
                        },
                        new
                        {
                            Id = new Guid("f14c83df-1fa4-4a83-8070-b16ecb19aa77"),
                            CreateAt = new DateTime(2024, 4, 28, 20, 16, 42, 499, DateTimeKind.Local).AddTicks(9707),
                            DescricaoPeriodo = "Dia Todo",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 20, 16, 42, 499, DateTimeKind.Local).AddTicks(9708)
                        },
                        new
                        {
                            Id = new Guid("7e107de8-c97a-435b-9976-7a689ca28bb7"),
                            CreateAt = new DateTime(2024, 4, 28, 20, 16, 42, 499, DateTimeKind.Local).AddTicks(9710),
                            DescricaoPeriodo = "Noturno",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 20, 16, 42, 499, DateTimeKind.Local).AddTicks(9711)
                        });
                });

            modelBuilder.Entity("Domain.Entities.Produto.ProdutoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("CategoriaProdutoEntityId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<string>("CodigoBarrasPersonalizado")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImgUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Observacoes")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<Guid>("ProdutoMedidaEntityId")
                        .HasColumnType("char(36)");

                    b.Property<Guid?>("ProdutoTipoEntityId")
                        .IsRequired()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaProdutoEntityId");

                    b.HasIndex("CodigoBarrasPersonalizado")
                        .IsUnique();

                    b.HasIndex("NomeProduto")
                        .IsUnique();

                    b.HasIndex("ProdutoMedidaEntityId");

                    b.HasIndex("ProdutoTipoEntityId");

                    b.ToTable("Produtos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("f0e75a80-0b64-4b2b-9f53-f3dce3f6d126"),
                            CategoriaProdutoEntityId = new Guid("a9b05f16-71f0-4f77-a653-52c1a15b36bc"),
                            CodigoBarrasPersonalizado = "01",
                            CreateAt = new DateTime(2024, 4, 28, 20, 16, 42, 499, DateTimeKind.Local).AddTicks(8440),
                            Descricao = "",
                            Habilitado = true,
                            ImgUrl = "",
                            NomeProduto = "Agua sem gas",
                            Observacoes = "",
                            ProdutoMedidaEntityId = new Guid("414a646f-1146-4b6d-bbfc-39a26e74a091"),
                            ProdutoTipoEntityId = new Guid("edddccfa-a4af-4831-b9ee-29bdd5f755af"),
                            UpdateAt = new DateTime(2024, 4, 28, 20, 16, 42, 499, DateTimeKind.Local).AddTicks(8453)
                        });
                });

            modelBuilder.Entity("Domain.Entities.ProdutoTipo.ProdutoTipoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("DescricaoTipoProduto")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("DescricaoTipoProduto")
                        .IsUnique();

                    b.ToTable("TiposProdutos", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("edddccfa-a4af-4831-b9ee-29bdd5f755af"),
                            CreateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(1243),
                            DescricaoTipoProduto = "Venda",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(1250)
                        },
                        new
                        {
                            Id = new Guid("1e11b25a-8bf5-4d57-80b7-396d09cbfcf1"),
                            CreateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(1251),
                            DescricaoTipoProduto = "Materia Prima",
                            Habilitado = true,
                            UpdateAt = new DateTime(2024, 4, 28, 23, 16, 42, 499, DateTimeKind.Utc).AddTicks(1254)
                        });
                });

            modelBuilder.Entity("Domain.Entities.UsuarioSistema.PerfilUsuarioEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("ConfirmarSenha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Habilitado")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("IdentityId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("IdentityId")
                        .IsUnique();

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("PerfilsUsuarios", (string)null);
                });

            modelBuilder.Entity("Api.Domain.Entities.PrecoProduto.PrecoProdutoEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.CategoriaPreco.CategoriaPrecoEntity", "CategoriaPrecoEntity")
                        .WithMany("PrecoProdutoEntities")
                        .HasForeignKey("CategoriaPrecoEntityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Produto.ProdutoEntity", "ProdutoEntity")
                        .WithMany("PrecoProdutoEntities")
                        .HasForeignKey("ProdutoEntityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CategoriaPrecoEntity");

                    b.Navigation("ProdutoEntity");
                });

            modelBuilder.Entity("Domain.Entities.Produto.ProdutoEntity", b =>
                {
                    b.HasOne("Domain.Entities.CategoriaProduto.CategoriaProdutoEntity", "CategoriaProdutoEntity")
                        .WithMany("ProdutoEntities")
                        .HasForeignKey("CategoriaProdutoEntityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.ProdutoMedida.ProdutoMedidaEntity", "ProdutoMedidaEntity")
                        .WithMany("ProdutoEntities")
                        .HasForeignKey("ProdutoMedidaEntityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Domain.Entities.ProdutoTipo.ProdutoTipoEntity", "ProdutoTipoEntity")
                        .WithMany("ProdutoEntities")
                        .HasForeignKey("ProdutoTipoEntityId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("CategoriaProdutoEntity");

                    b.Navigation("ProdutoMedidaEntity");

                    b.Navigation("ProdutoTipoEntity");
                });

            modelBuilder.Entity("Api.Domain.Entities.CategoriaPreco.CategoriaPrecoEntity", b =>
                {
                    b.Navigation("PrecoProdutoEntities");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProdutoMedida.ProdutoMedidaEntity", b =>
                {
                    b.Navigation("ProdutoEntities");
                });

            modelBuilder.Entity("Domain.Entities.CategoriaProduto.CategoriaProdutoEntity", b =>
                {
                    b.Navigation("ProdutoEntities");
                });

            modelBuilder.Entity("Domain.Entities.Produto.ProdutoEntity", b =>
                {
                    b.Navigation("PrecoProdutoEntities");
                });

            modelBuilder.Entity("Domain.Entities.ProdutoTipo.ProdutoTipoEntity", b =>
                {
                    b.Navigation("ProdutoEntities");
                });
#pragma warning restore 612, 618
        }
    }
}
