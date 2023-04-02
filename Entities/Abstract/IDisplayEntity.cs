using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
    public interface IDisplayEntity
    {
        int DisplayOrder { get; set; }
        bool IsDisplay { get; set; }
    }
}
