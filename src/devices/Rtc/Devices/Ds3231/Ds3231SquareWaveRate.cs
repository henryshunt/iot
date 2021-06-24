using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iot.Device.Rtc
{
    /// <summary>
    /// Available square wave frequencies
    /// </summary>
    public enum Ds3231SquareWaveRate : byte
    {
        /// <summary>
        /// 1Hz
        /// </summary>
        Rate1Hz = 0x00,

        /// <summary>
        /// 1.024kHz
        /// </summary>
        Rate1_024kHz = 0x01,

        /// <summary>
        /// 4.096kHz
        /// </summary>
        Rate4_096kHz = 0x02,

        /// <summary>
        /// 8.192kHz
        /// </summary>
        Rate8_192kHz = 0x03
    }
}
