﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.ProductType.Request
{

    public class ProductTypePutRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
