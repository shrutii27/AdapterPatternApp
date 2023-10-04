﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternApp.Model
{
    internal interface IPersonInfo
    {
        string GetFirstName();
        string GetLastName();
        void PrintFullName();

    }
}
