using Microsoft.EntityFrameworkCore;
using System;

namespace AisParser
{
    //for indexing
    [Index(nameof(DateTimeUTC))]
    [Index(nameof(Mmsi))]
    public abstract class AisMessage
    {
        //required for entity framework index
        public long Id { get; set; }
        public DateTime DateTimeUTC { get; set; }
        public string Source { get; set; }

        public AisMessageType MessageType { get; }
        public uint Repeat { get; set; }
        public uint Mmsi { get; set; }

        protected AisMessage(AisMessageType messageType)
        {
            MessageType = messageType;
        }

        protected AisMessage(AisMessageType messageType, Payload payload)
            : this(messageType)
        {
            Repeat = payload.ReadUInt(6, 2);
            Mmsi = payload.ReadUInt(8, 30);
        }
    }
}