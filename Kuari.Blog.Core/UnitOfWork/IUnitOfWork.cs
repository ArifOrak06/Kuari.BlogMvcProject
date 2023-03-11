﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuari.Blog.Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
    }
}
