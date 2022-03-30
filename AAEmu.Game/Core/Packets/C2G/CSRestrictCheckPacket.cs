﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Core.Packets.G2C;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSRestrictCheckPacket : GamePacket
    {
        public CSRestrictCheckPacket() : base(CSOffsets.CSRestrictCheckPacket, 5)
        {
        }

        public override void Read(PacketStream stream)
        {
            _log.Debug("CSRestrictCheckPacket");

            var characterId = stream.ReadUInt32();
            var restrictCode = stream.ReadByte();
            Connection.SendPacket(new SCResultRestrictCheckPacket(characterId, restrictCode, 0));
            Connection.SendPacket(new SCCheckRaceCongestionResponsePacket());
        }
    }
}
