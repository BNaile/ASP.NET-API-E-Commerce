﻿using E_CommerceAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Abstarction
{
  
    
    public interface IProductSercive
    {
        List<Product> GetProducts();
    }
}
