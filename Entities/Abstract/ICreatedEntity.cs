using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstract
{
    public interface ICreatedEntity
    {
        int CreatedUserId { get; set; }
        DateTime CreatedDate { get; set; }
    }
}
