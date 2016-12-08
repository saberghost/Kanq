using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanq.Common
{
    public class EntityHelper
    {
        /// <summary>
        /// 将一个实体类复制到另一个实体类
        /// </summary>
        /// <param name="objectsrc">源实体类</param>
        /// <param name="objectdest">复制到的实体类</param>
        /// <param name="excudeFields">不复制的属性</param>
        public static void EntityToEntity(object objectsrc, object objectdest, params string[] excudeFields)
        {
            var sourceType = objectsrc.GetType();
            var destType = objectdest.GetType();
            foreach (var item in destType.GetProperties())
            {
                if (excudeFields.Any(x => x == item.Name))
                    continue;
                item.SetValue(objectdest, sourceType.GetProperty(item.Name).GetValue(objectsrc, null), null);
            }
        }
    }
}
