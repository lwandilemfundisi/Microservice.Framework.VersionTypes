using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microservice.Framework.VersionTypes
{
    public interface IVersionedTypeUpgrader<in TFrom, TTo>
        where TFrom : IVersionedType
        where TTo : IVersionedType
    {
        Task<TTo> UpgradeAsync(TFrom fromVersionedType, CancellationToken cancellationToken);
    }
}
