using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class PaginacaoViewModel
    {
        [FromQuery(Name = "offset")]
        public int offset { get; set; }

        [FromQuery(Name = "limit")]
        public int limit { get; set; }
    }
}
