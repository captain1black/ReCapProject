using Busieness.Abstract;
using DateAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Busieness.Concrete
{
    public class ColorManager : IColorService 
    {
        EfColorDal _color;

        public ColorManager(EfColorDal color)
        {
            _color = color;
        }
        public void Add(Color color)
        {
            _color.Add(color);
        }

        public void Delete(Color color)
        {
            _color.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _color.GetAll();
        }

        public Color GetCarsByColorId(int colorId)
        {
            return _color.Get(c => c.ColorId == colorId);
        }

        public void Update(Color color)
        {
            _color.Update(color);
        }
    }
}
