﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSExpeditionChangeOwnerPacket : GamePacket
    {
        public CSExpeditionChangeOwnerPacket() : base(CSOffsets.CSExpeditionChangeOwnerPacket, 5)
        {
        }

        public override void Read(PacketStream stream)
        {
            _log.Debug("CSExpeditionChangeOwnerPacket");
        }
    }
}
