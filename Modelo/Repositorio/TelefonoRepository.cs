﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Olfrad.EscuelaSimple.Entidad;
using NHibernate;

namespace Olfrad.EscuelaSimple.Modelo.Repositorio
{
    public class TelefonoRepository : NHibernateRepository<Telefono, uint>, ITelefonoRepository
    {
        public TelefonoRepository(ISession session)
            : base(session)
        {

        }
    }

    public interface ITelefonoRepository : IRepository<Telefono, uint>
    {
    }
}
