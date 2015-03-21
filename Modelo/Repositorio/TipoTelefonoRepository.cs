﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Olfrad.EscuelaSimple.Entidad;
using NHibernate;

namespace Olfrad.EscuelaSimple.Modelo.Repositorio
{
    public class TipoTelefonoRepository : NHibernateRepository<TipoTelefono, uint>, ITipoTelefonoRepository
    {
        public TipoTelefonoRepository(ISession session)
            : base(session)
        {

        }
    }

    public interface ITipoTelefonoRepository : IRepository<TipoTelefono, uint>
    {

    }
}
