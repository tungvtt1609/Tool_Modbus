using System;
using System.Collections.Generic;
using System.Text;

namespace Modbus_Poll_CS
{
    public enum VarType
    {
        Float = 0,
        Short,
        Int
    }
    public enum VarAddr 
    { 
        Etotal  = 0,        // Variable 
        Pin, 
        Pout,
        Pmax,
        Vrms,
        Irms,
        Freq,
        PF,
        Vpv1,
        Ipv1,
        Vpv2,
        Ipv2,
        Ileak,
        Temp,
        Cum,
        Time,
        Date,
        Err,
        Vbus,
        VA,
        Vema,
        Vac,
        fw_major,
        fw_minor,
        UpdateReq,
        UpdateTime,

        CoeffApply = 250, // Coeff signal
        Vpv1Gain,             
        Vpv1Offset,
        Ipv1Gain,
        Ipv1Offset,
        Vpv2Gain,
        Vpv2Offset,
        Ipv2Gain,
        Ipv2Offset,
        VbusGain,
        VbusOffset,
        VgridGain,
        VgridOffset,
        VacGain,
        VacOffset,
        IgridGain,
        IgridOffset,
        IleakGain,
        IleakOffset,
        GroundFailGain,
        GroundFailOffset,
        LineEarthGain,
        LineEarthOffset,
        NatureEarthGain,
        NatureEarthOffset,
        TempGain,
        TempOffset,


        ControlerApply = 500,
        KpVol,
        KiVol,
        PrKp,
        PrKi1,
        PrKi3,
        PrKi5,
        PrKi7,
        PrKi9,
        KpCur,
        KiCur,

        NVDataApply = 750,
        Varlist = 1000,

        DlogIn1 = 1250,
        DlogIn2,
        DlogIn3,
        DlogIn4,
        PreScalar,
        Enable,
        Status,
        outPtr1,
        outPtr2,
        outPtr3,
        outPtr4,
        preVal,
        trigerValue,
        dataDlog1 = 1500,
        dataDlog2 = 1900,
        dataDlog3 = 2300,
        dataDlog4 = 2700,
        data = 3100,

        logeventindex = 3500,
        logeventdata,
        logStt,
        logDateTime,
        logType,
        logguiErrCode,
        logguiPin,
        logguiVrms,
        logguiIrms,
        logguiFreqAvg,
        logguiPowerFactor,
        logguiVpv1,
        logguiIpv1,
        logguiVpv2,
        logguiIpv2,
        logguiTempt,
        logguiCum,
        logguiVbus,

        DeviceState = 4000,
        DeviceInfo = 4200,
        DeviceReadInfo = 4400,

        // Config Data Region
        Config_Apply = 4500,
        Config_File_Vesion,
        Config_Pmax,
        Config_Vmax,
        Config_Reserve4,
        Config_Reserve5,
        Config_Reserve6,
        Config_Reserve7,
        Config_Reserve8,
        Config_Reserve9,
        Config_Reserve10,
        Config_Reserve11,
        Config_Reserve12,
        Config_Reserve13,
        Config_Reserve14,
        Config_Reserve15,
        Config_Reserve16,
        Config_Reserve17,
        Config_Reserve18,
        Config_Reserve19,
        Config_Reserve20,
        Config_Reserve21,
        Config_Reserve22,
        Config_Reserve23,
        Config_Reserve24,
        Config_Reserve25,
        Config_Reserve26,
        Config_Reserve27,
        Config_Reserve28,
        Config_Reserve29,
        Config_Reserve30,

        // For App Test
        DeviceAdc = 4600,

        DeviceAdcParam = 4800,
        DeviceAdcParamVpv10,
        DeviceAdcParamVpv11,
        DeviceAdcParamVpv20,
        DeviceAdcParamVpv21,

        DeviceAdcValue = 5000,
        DeviceAdcValueVpv1,
        DeviceAdcValueVpv2,

        DeviceDuty = 5200,
        DeviceRelay = 5210,

    }

    public class DataRegister
    {
        public ushort[] data_source = new ushort[12000];
    }
}
