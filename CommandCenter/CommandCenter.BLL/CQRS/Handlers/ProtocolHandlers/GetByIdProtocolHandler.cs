﻿using CommandCenter.BLL.CQRS.Handlers.Base;
using CommandCenter.Core.Entities;
using CommandCenter.Core.Interfaces.CQRS.Handlers.ProtocolHandlers;
using CommandCenter.Core.Interfaces.Profiles.MapperProfiles;
using CommandCenter.Core.Repositories;
using CommandCenter.Core.Resources;
using Microsoft.Extensions.Logging;

namespace CommandCenter.BLL.CQRS.Handlers.ProtocolHandlers
{
    public class GetByIdProtocolHandler : BaseGetByIdHandler<Protocol, ProtocolGetResource>, IGetByIdProtocolHandler
    {
        public GetByIdProtocolHandler(IProtocolRepository repository, IDataMapper dataMapper, ILogger<GetByIdProtocolHandler> logger)
            : base(repository, dataMapper, logger)
        {
        }
    }
}
