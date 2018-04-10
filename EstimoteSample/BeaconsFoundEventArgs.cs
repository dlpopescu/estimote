using System;
using System.Collections.Generic;
using System.Linq;
using EstimoteSdk;

namespace Estimotes.Droid
{
    class BeaconsFoundEventArgs : EventArgs
    {
        public BeaconsFoundEventArgs(IEnumerable<Beacon> beacons)
        {
            Beacons = beacons?.ToArray() ?? new Beacon[0];
        }

        public Beacon[] Beacons { get; private set; }
    }
}
