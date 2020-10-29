using System;
using System.Collections.Generic;
using System.Linq;

namespace InstagramApiSharp.Classes.Android.DeviceInfo
{
    public class AndroidDeviceGenerator
    {
        private static readonly List<string> DevicesNames = new List<string>
        {
            AndroidDevices.LG_OPTIMUS_G,
            
        };

        public static Dictionary<string, AndroidDevice> AndroidAndroidDeviceSets = new Dictionary<string, AndroidDevice>
        {
            {
                "lg-optimus-g",
                new AndroidDevice
                {
                    AndroidBoardName = "geehrc",
                    AndroidBootloader = "MAKOZ10f",
                    DeviceBrand = "LGE",
                    DeviceModel = "LG-LS970",
                    DeviceModelBoot = "qcom",
                    DeviceModelIdentifier = "cm_ls970",
                    FirmwareBrand = "cm_ls970",
                    FirmwareFingerprint = "google/occam/mako:4.2.2/JDQ39/573038:user/release-keys",
                    FirmwareTags = "test-keys",
                    FirmwareType = "userdebug",
                    HardwareManufacturer = "LGE",
                    HardwareModel = "LG-LS970",
                    DeviceGuid = Guid.NewGuid(),
                    PhoneGuid = Guid.NewGuid(),
                    Resolution = "1440x2560",
                    Dpi = "640dpi"
                }
            }
        };

        static Random Rnd = new Random();
        private static AndroidDevice LastDevice;
        public static AndroidDevice GetRandomAndroidDevice()
        {
            TryLabel:
            var randomDeviceIndex = Rnd.Next(0, DevicesNames.Count);
            var device = AndroidAndroidDeviceSets.ElementAt(randomDeviceIndex).Value;
            device.PhoneGuid = Guid.NewGuid();
            device.DeviceGuid = Guid.NewGuid();
            device.DeviceId = ApiRequestMessage.GenerateDeviceIdFromGuid(device.DeviceGuid);
            device.PigeonSessionId = Guid.NewGuid();
            device.PushDeviceGuid = Guid.NewGuid();
            device.FamilyDeviceGuid = Guid.NewGuid();
            device.IGBandwidthSpeedKbps = $"{Rnd.Next(1233, 1567)}.{Rnd.Next(100, 999)}";
            device.IGBandwidthTotalTimeMS = Rnd.Next(781, 999).ToString();
            try
            {
                device.IGBandwidthTotalBytesB = ((int)((double.Parse(device.IGBandwidthSpeedKbps) * double.Parse(device.IGBandwidthTotalTimeMS)) + Rnd.Next(100, 999))).ToString();
            }
            catch { }
            if (LastDevice != null)
                if (device.DeviceId == LastDevice.DeviceId)
                    goto TryLabel;
            LastDevice = device;
            return device;
        }

        public static AndroidDevice GetByName(string name)
        {
            return AndroidAndroidDeviceSets[name];
        }

        //public static AndroidDevice GetById(string deviceId)
        //{
        //    return (from androidAndroidDeviceSet in AndroidAndroidDeviceSets
        //            where androidAndroidDeviceSet.Value.DeviceId == deviceId
        //            select androidAndroidDeviceSet.Value).FirstOrDefault();
        //}
    }
}