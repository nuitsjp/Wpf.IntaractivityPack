using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf
{
    public class OpenFilesDialogServiceFactory : IOpenFilesDialogServiceFactory
    {
        public IOpenFilesDialogService Create() => new OpenFilesDialogService();
    }
}
