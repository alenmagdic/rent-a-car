﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IMainView
    {
        string Username { get; }
        string Password { get; }
        void UpdateView();
    }
}
