﻿using CommandCenter.Core.Entities;
using CommandCenter.Core.Interfaces.CQRS.Handlers.Base;
using CommandCenter.Core.Resources;

namespace CommandCenter.Core.Interfaces.CQRS.Handlers.FrameworkHandlers
{
    public interface IGetAllFrameworksHandler : IBaseGetAllHandler<Framework, FrameworkGetResource>
    {
    }
}
