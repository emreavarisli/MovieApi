﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Results.CategoryResults
{
    class GetCategoryByIdQueryResults
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
