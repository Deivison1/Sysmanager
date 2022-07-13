using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.Category.Request
{
    public class CategoryGetFilterRequest
    {
        public string Name { get; set; }
        public string Active { get; set; }

        public int page { get; set; }

        public int pageSise { get; set; }
    }
}
