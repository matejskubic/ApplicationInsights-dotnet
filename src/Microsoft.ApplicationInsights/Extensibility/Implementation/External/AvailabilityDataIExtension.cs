﻿namespace Microsoft.ApplicationInsights.Extensibility.Implementation.External
{
    using System.Diagnostics;
    using Microsoft.ApplicationInsights;
    using Microsoft.ApplicationInsights.DataContracts;

    /// <summary>
    /// Partial class to implement IExtension
    /// </summary>
    internal partial class AvailabilityData : IExtension
    {
        public void Serialize(ISerializationWriter serializationWriter)
        {
            serializationWriter.WriteProperty("ver", this.ver);
            serializationWriter.WriteProperty("id", this.id);
            serializationWriter.WriteProperty("name", this.name);
            serializationWriter.WriteProperty("duration", this.duration);
            serializationWriter.WriteProperty("success", this.success);
            serializationWriter.WriteProperty("runLocation", this.runLocation);
            serializationWriter.WriteProperty("message", this.message);
            serializationWriter.WriteDictionary("properties", this.properties);
            serializationWriter.WriteDictionary("measurements", this.measurements);
        }

        IExtension IExtension.DeepClone()
        {
            return this.DeepClone();
        }
    }
}
