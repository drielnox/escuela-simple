﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Olfrad.EscuelaSimple.Entidad;

namespace Olfrad.EscuelaSimple.Modelo.Repositorio
{
    public interface IRepository<TEntity, in TKey> : IReadOnlyRepository<TEntity, TKey>
        where TEntity : IEntity<TKey>
        where TKey : struct
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
