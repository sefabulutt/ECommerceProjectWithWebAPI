using System;

namespace Entities.Abstract
{
    internal interface IUpdatedEntity
    {
        int? UpdatedUserId { get; set; }
        DateTime? UpdatedDate { get; set; }
    }
}
