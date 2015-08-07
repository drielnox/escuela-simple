﻿using EscuelaSimple.Aplicacion.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EscuelaSimple.Datos.Mapeo.EntityFramework
{
    public class TelefonoConfiguracion : EntityTypeConfiguration<Telefono>
    {
        public TelefonoConfiguracion()
        {
            ToTable("Telefono");
                
            HasKey<int>(x => x.Identificador);

            Property<int>(x => x.Identificador).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property<int>(x => x.Numero);

            HasRequired<TipoTelefono>(x => x.Tipo).WithRequiredDependent();
        }
    }
}