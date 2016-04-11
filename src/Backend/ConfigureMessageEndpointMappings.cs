﻿namespace Frontend.Config
{
    using NServiceBus.Config;
    using NServiceBus.Config.ConfigurationSource;

    public class ConfigureMessageEndpointMappings : IProvideConfiguration<UnicastBusConfig>
    {
        public UnicastBusConfig GetConfiguration()
        {
            return new UnicastBusConfig
            {
                MessageEndpointMappings = new MessageEndpointMappingCollection
                {
                    new MessageEndpointMapping
                    {
                        Endpoint = "Frontend",
                        Messages = "Messages.Pong, Messages"
                    }
                }
            };
        }
    }
}