namespace Iot.Device.Rtc
{
    /// <summary>
    /// Available modes for the INT/SQW pin
    /// </summary>
    public enum Ds3231IntSqwPinMode : byte
    {
        /// <summary>
        /// The INT/SQW pin will output a square wave
        /// </summary>
        SquareWave = 0,

        /// <summary>
        /// The INT/SQW pin will pulse when an alarm triggers
        /// </summary>
        Alarm = 1
    }
}
