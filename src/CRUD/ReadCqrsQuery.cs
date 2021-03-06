﻿using System;
using System.Linq;
using Kaftar.Core.Cqrs.QueryStack.Queries;
using Kaftar.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Kaftar.Core.Cqrs.CRUD
{
    public class ReadCqrsQuery<TEntity>:CqrsQuery
        where TEntity: class
    {
        public ReadCqrsQuery()
        {
            // set default query
            QueryConfiguration = (query) => query;
        }
        public TEntity Entity { get; set; }

        public Func<IQueryable<TEntity>, IQueryable<TEntity>> QueryConfiguration;
    }

}
