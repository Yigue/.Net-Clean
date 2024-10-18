using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Reviews;

public sealed record ReviewId(Guid v)
{
    public static ReviewId New()=> new(Guid.NewGuid());
}