﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MybookWeb.Entities;

namespace MybookWeb.Interface
{
    public interface IAuthor
    {
        void Add(Author author);
        Task<bool> AddAsync(Author author);
        Task<bool> Update(Author author);
        Task<IEnumerable<Author>> GetAll();
        Task<Author> GetById(int Id);
        Task<bool> Delete(int Id);
    }
}
