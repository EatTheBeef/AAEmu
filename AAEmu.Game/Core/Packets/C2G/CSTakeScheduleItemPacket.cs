﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSTakeScheduleItemPacket : GamePacket
    {
        public CSTakeScheduleItemPacket() : base(CSOffsets.CSTakeScheduleItemPacket, 5)
        {
        }

        public override void Read(PacketStream stream)
        {
            _log.Debug("CSTakeScheduleItemPacket");
        }
    }
}
