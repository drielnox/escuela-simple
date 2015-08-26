﻿using EscuelaSimple.Aplicacion.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace EscuelaSimple.Datos.Utilitarios.Configuraciones.Mapeo.EntityFramework
{
    public class CargoTypeConfiguration : EntityTypeConfiguration<Cargo>
    {
        public CargoTypeConfiguration()
        {
            ToTable("Cargo");

            HasKey<int>(x => x.Identificador);

            Property<int>(x => x.Identificador)
                .HasColumnName("IdCargo")
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property<byte>(x => x.Secuencia)
                .HasColumnName("Secuencia")
                .IsRequired();

            HasMany<Funcion>(x => x.Funciones)
                .WithRequired()
                .Map(x =>
                {
                    x.MapKey("IdCargo");
                    x.HasColumnAnnotation("IdCargo", "FK_Cargo_Funcion_1", new IndexAnnotation(new IndexAttribute() { IsUnique = true }));
                });
        }
    }
}
