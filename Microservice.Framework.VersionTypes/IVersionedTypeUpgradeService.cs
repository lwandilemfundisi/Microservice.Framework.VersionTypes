using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microservice.Framework.VersionTypes
{
    public interface IVersionedTypeUpgradeService<TAttribute, TDefinition, TVersionedType>
        where TAttribute : VersionedTypeAttribute
        where TDefinition : VersionedTypeDefinition
        where TVersionedType : IVersionedType
    {
        Task<TVersionedType> UpgradeAsync(TVersionedType versionedType, CancellationToken cancellationToken);
    }
}
