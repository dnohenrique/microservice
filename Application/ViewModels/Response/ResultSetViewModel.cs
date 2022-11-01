using Application.ViewModels.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class ResultsetViewModel : ResultsetBase
    {
        public ResultsetViewModel(string type)
        {
            Type = type;
        }
    }
}
