﻿namespace AisParser.Messages
{
    public class StaticDataReportPartAMessage : StaticDataReportMessage
    {
        public string ShipName { get; set; }
        public uint Spare { get; set; }

        public StaticDataReportPartAMessage()
        {
        }

        public StaticDataReportPartAMessage(StaticDataReportMessage message, Payload payload)
            : base(message)
        {
            ShipName = payload.ReadString(40, 120);
            Spare = payload.ReadUInt(160, 8);
        }
    }
}