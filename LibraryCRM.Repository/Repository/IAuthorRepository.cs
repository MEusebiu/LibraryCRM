﻿using LibraryCRM.DataContext.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCRM.Repository.Repository
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IList<Author> GetWhereNamesHam();
    }
}