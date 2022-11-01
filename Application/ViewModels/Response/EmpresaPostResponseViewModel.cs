using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels.Response
{
    public class EmpresaPostResponseViewModel<TResult>
    {
        [JsonProperty(PropertyName = "metadata")]
        public MetaDataViewModel MetaDataViewModel { get; set; }
        public TResult Result { get; set; }
    }
}
