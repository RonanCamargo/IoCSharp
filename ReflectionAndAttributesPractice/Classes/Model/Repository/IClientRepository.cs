﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAndAttributesPractice.Classes.Model.Repository
{
    interface IClientRepository : IRepository<long,long>
    {
        void print();
    }
}
