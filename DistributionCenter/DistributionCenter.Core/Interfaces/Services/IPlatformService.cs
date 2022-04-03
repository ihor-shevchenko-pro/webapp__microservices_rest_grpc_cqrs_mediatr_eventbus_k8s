﻿using DistributionCenter.Core.Entities;
using DistributionCenter.Core.Interfaces.Services.Base;
using DistributionCenter.Core.Resources;

namespace DistributionCenter.Core.Interfaces.Services
{
    public interface IPlatformService : IBaseService<PlatformCreateResource, PlatformGetResource, Platform>
    {
    }
}
