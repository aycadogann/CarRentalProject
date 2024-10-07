using Business.Abstract;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class IColorManager : IColorService
    {
        IColorDal _colorDal;

        public IColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }



    }
}
