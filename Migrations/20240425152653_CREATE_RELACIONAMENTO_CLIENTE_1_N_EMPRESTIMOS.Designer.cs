﻿// <auto-generated />
using System;
using BookGenius.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.EntityFrameworkCore.Metadata;

#nullable disable

namespace BOOK_GENIUS.Migrations
{
    [DbContext(typeof(OracleFIAPDbContext))]
    [Migration("20240425152653_CREATE_RELACIONAMENTO_CLIENTE_1_N_EMPRESTIMOS")]
    partial class CREATE_RELACIONAMENTO_CLIENTE_1_N_EMPRESTIMOS
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            OracleModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BOOK_GENIUS.Models.Autores", b =>
                {
                    b.Property<int>("AutorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AutorId"));

                    b.Property<string>("Biografia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR2(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("AutorId");

                    b.ToTable("BGENIUS_AUTOR");
                });

            modelBuilder.Entity("BOOK_GENIUS.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("ClienteId");

                    b.ToTable("BGENIUS_CLIENTE");
                });

            modelBuilder.Entity("BOOK_GENIUS.Models.Editoras", b =>
                {
                    b.Property<int>("EditoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EditoraId"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("EditoraId");

                    b.ToTable("BGENIUS_EDITORA");
                });

            modelBuilder.Entity("BOOK_GENIUS.Models.Emprestimos", b =>
                {
                    b.Property<int>("EmprestimoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmprestimoId"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<DateTime>("DataEmprestimo")
                        .HasColumnType("TIMESTAMP(7)");

                    b.Property<int>("LivroId")
                        .HasColumnType("NUMBER(10)");

                    b.HasKey("EmprestimoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("LivroId");

                    b.ToTable("BGENIUS_EMPRESTIMO");
                });

            modelBuilder.Entity("BOOK_GENIUS.Models.Livros", b =>
                {
                    b.Property<int>("LivroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("NUMBER(10)");

                    OraclePropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LivroId"));

                    b.Property<int>("AutorId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<int>("EditoraId")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.Property<int>("Paginas")
                        .HasColumnType("NUMBER(10)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("NVARCHAR2(2000)");

                    b.HasKey("LivroId");

                    b.HasIndex("AutorId")
                        .IsUnique();

                    b.HasIndex("EditoraId");

                    b.ToTable("BGENIUS_LIVRO");
                });

            modelBuilder.Entity("BOOK_GENIUS.Models.Emprestimos", b =>
                {
                    b.HasOne("BOOK_GENIUS.Models.Clientes", "Cliente")
                        .WithMany("Emprestimos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BOOK_GENIUS.Models.Livros", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Livro");
                });

            modelBuilder.Entity("BOOK_GENIUS.Models.Livros", b =>
                {
                    b.HasOne("BOOK_GENIUS.Models.Autores", "Autor")
                        .WithOne("Livro")
                        .HasForeignKey("BOOK_GENIUS.Models.Livros", "AutorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BOOK_GENIUS.Models.Editoras", "Editora")
                        .WithMany("Livros")
                        .HasForeignKey("EditoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Autor");

                    b.Navigation("Editora");
                });

            modelBuilder.Entity("BOOK_GENIUS.Models.Autores", b =>
                {
                    b.Navigation("Livro")
                        .IsRequired();
                });

            modelBuilder.Entity("BOOK_GENIUS.Models.Clientes", b =>
                {
                    b.Navigation("Emprestimos");
                });

            modelBuilder.Entity("BOOK_GENIUS.Models.Editoras", b =>
                {
                    b.Navigation("Livros");
                });
#pragma warning restore 612, 618
        }
    }
}
