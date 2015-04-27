﻿using EscuelaSimple.Entidad;
using NHibernate;

namespace EscuelaSimple.Modelo.Repositorio
{
    public class TipoTelefonoRepositorio : NHibernateRepositorio<TipoTelefono, uint>, ITipoTelefonoRepositorio
    {
        public TipoTelefonoRepositorio(ISession session)
            : base(session)
        {

        }
    }

    public interface ITipoTelefonoRepositorio : IRepositorio<TipoTelefono, uint>
    {

    }
}
