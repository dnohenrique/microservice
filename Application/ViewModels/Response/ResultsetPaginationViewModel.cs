using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels.Response
{
    public class ResultsetPaginationViewModel : ResultsetBase
    {
        public int Offset { get; private set; }
        public int Limit { get; private set; }
        public long Total { get; private set; }

        public ResultsetPaginationViewModel(string type, int offset = 0, int limit = 0, long total = 0)
        {
            Offset = offset;
            Limit = limit;
            Total = total;
            Type = type;
        }
    }
}
