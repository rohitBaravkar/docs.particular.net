﻿using NServiceBus;
using NServiceBus.Transport.SQLServer;

class SingleDbMultiSchema
{
    void CurrentEndpointSchema(EndpointConfiguration endpointConfiguration)
    {
        #region sqlserver-singledb-multischema

        var transport = endpointConfiguration.UseTransport<SqlServerTransport>();
        transport.DefaultSchema("myschema");

        #endregion
    }

    void OtherEndpointConnectionParamsPull(EndpointConfiguration endpointConfiguration)
    {
        #region sqlserver-singledb-multidb-pull

        var transport = endpointConfiguration.UseTransport<SqlServerTransport>();
        transport.UseSchemaForEndpoint("AnotherEndpoint", "receiver1");

        #endregion
    }
}
