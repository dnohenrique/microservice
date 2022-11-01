using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class EmpresaGetResponseViewModel<TResult> 
    {
        [JsonProperty(PropertyName = "metadata")]
        public MetaDataViewModel MetaDataViewModel { get; set; }
        public TResult Result { get; set; }
    }
}
