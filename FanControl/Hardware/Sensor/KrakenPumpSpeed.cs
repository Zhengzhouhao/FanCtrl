﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FanControl
{
    public class KrakenPumpSpeed : BaseSensor
    {
        private Kraken mKraken = null;

        public KrakenPumpSpeed(Kraken kraken) : base(SENSOR_TYPE.FAN)
        {
            mKraken = kraken;
            Name = "NZXT Kraken Pump";
        }

        public override string getString()
        {
            var valueString = string.Format("{0:D4}", Value);
            return valueString + " RPM";
        }

        public override void update()
        {
            Value = mKraken.getPumpSpeed();
        }
    }
}