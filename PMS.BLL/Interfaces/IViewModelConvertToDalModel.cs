﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMS.BLL.Interfaces
{
    internal interface IViewModelConvertToDalModel<T,TX>
    {
         T ConvertToDal(TX viewModel);
         TX ConvertToViewModel(T model);
    }
}
