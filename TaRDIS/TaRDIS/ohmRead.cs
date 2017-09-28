using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenHardwareMonitor.Collections;
using OpenHardwareMonitor.Hardware;
namespace TaRDIS
{
    class ohmRead
    {
        Computer myPC;
        ISensor CPUtemp;

        public string getCPUtemp()
        {
            CPUtemp.Hardware.Update();
            if (myPC.CPUEnabled)
                 return CPUtemp.Value.ToString()+"°C";
            else
                return "n/a";
        }
        public ohmRead(bool CPU, bool GPU, bool HDD)
        {
            myPC = new Computer();
            myPC.Open();
            myPC.CPUEnabled = CPU;
            myPC.GPUEnabled = GPU;
            myPC.HDDEnabled = HDD;

            if(CPU)
            {
                CPUtemp = myPC.Hardware.First(obj => obj.HardwareType == HardwareType.CPU).Sensors.First(sens => sens.Name == "CPU Package" && sens.SensorType == SensorType.Temperature);
            }
        }

    }
}
