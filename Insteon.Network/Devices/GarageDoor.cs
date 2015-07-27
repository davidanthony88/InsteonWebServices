﻿using Insteon.Network.Device;

namespace Insteon.Network.Devices
{
    public class GarageDoor : IoLinc
    {
        internal GarageDoor(InsteonNetwork network, InsteonAddress address, InsteonIdentity identity)
            : base(network, address, identity)
        {
        }
    }
}
