﻿using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISvCategory
    {
        public Category Add(Category category);
        IEnumerable<Category> GetAll();
    }
}
