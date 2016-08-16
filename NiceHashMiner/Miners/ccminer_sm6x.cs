﻿using NiceHashMiner.Configs;
using NiceHashMiner.Devices;
using NiceHashMiner.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHashMiner.Miners {
    class ccminer_sm6x : ccminer_sm5x {
        public ccminer_sm6x(bool queryComputeDevices) :
            base(queryComputeDevices)
        {
            MinerDeviceName = "NVIDIA6.x";
            Path = MinerPaths.ccminer_nanashi;

            TryQueryCDevs();
        }

        protected override MinerType GetMinerType() {
            return MinerType.ccminer_sm6x;
        }

        protected override bool IsGroupQueryEnabled() {
            return !ConfigManager.Instance.GeneralConfig.DeviceDetection.DisableDetectionNVidia6X;
        }

        protected override bool IsPotentialDevSM(string name) {
            return name.Contains("SM 6.");
        }
    }
}
