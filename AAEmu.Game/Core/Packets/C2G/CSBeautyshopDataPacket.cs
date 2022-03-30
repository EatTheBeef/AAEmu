﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSBeautyshopDataPacket : GamePacket
    {
        public CSBeautyshopDataPacket() : base(CSOffsets.CSBeautyshopDataPacket, 5)
        {
        }

        public override void Read(PacketStream stream)
        {
            _log.Debug("CSBeautyshopDataPacket");
        }
    }
}
