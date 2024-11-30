using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESO.Model;

namespace ESO.ViewModel
{
    class IbexVM: Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;

        public IbexVM()
        {
            _pageModel = new PageModel();
        }
    }
}
