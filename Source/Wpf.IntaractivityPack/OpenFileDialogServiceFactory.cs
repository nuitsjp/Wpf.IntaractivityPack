﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf
{
    public class OpenFileDialogServiceFactory : IOpenFileDialogServiceFactory
    {
        public IOpenFileDialogService Create() => new OpenFileDialogService();
    }
}
