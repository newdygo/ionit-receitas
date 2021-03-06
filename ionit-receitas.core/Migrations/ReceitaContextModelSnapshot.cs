﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ionit.receitas.core.Context;

namespace ionit.receitas.core.Migrations
{
    [DbContext(typeof(ReceitaContext))]
    partial class ReceitaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ionit.receitas.core.Entities.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ingredientes");

                    b.Property<string>("ModoPreparo");

                    b.Property<string>("TempoPreparo");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Receita");
                });
        }
    }
}
