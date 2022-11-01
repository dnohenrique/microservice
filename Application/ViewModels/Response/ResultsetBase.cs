using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels.Response
{
    public abstract class ResultsetBase
    {
        public string Type { get; protected set; }
        
    }

    public enum ReturnType
    {
        List = 1,
        Object = 2,
        Bool = 3,
        String = 4,
        Int = 5
    }
    
}
