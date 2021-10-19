using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerUtilities
{
    /// <summary>
    /// Flags representing each of the job codes in the kitchen
    /// </summary>
    [Flags][Serializable]
    public enum JobCodes : ulong
    {
        D1 = 1, //Supervisor
        D2 = 2, //Lead 1
        D3 = 4, //Lead 2

        //cafeteria
        D4 = 8,
        D5 = 16,
        D6 = 32,
        D7 = 64,
        D8 = 128,
        D9 = 256,
        D10 = 512,
        D11 = 1024,

        //production
        D12 = 2048,
        D13 = 4096,
        D14 = 8192,
        D15 = 16384,
        D16 = 32768,
        D17 = 65536,

        //unused
        D18 = 131072,
        D19 = 262144,
        D20 = 524288,

        //line cooks
        D21 = 1048576,
        D22 = 2097152,
        D23 = 4194304,
        D24 = 8388608,
        D25 = 16777216,
        D26 = 33554432,
        D27 = 67108864,
        D28 = 134217728,
        D29 = 268435456,

        //unused
        D30 = 536870912,

        //relief cooks
        D31 = 1073741824,
        D32 = 2147483648,
        D33 = 4294967296,
        D34 = 8589934592,
        D35 = 17179869184,
        D36 = 34359738368,
        D37 = 68719476736,
        D38 = 137438953472,
        D39 = 274877906944,
        D40 = 549755813888,
        D41 = 1099511627776,
        D42 = 2199023255552,
        D43 = 4398046511104,
        D44 = 8796093022208,
        D45 = 17592186044416,
        D46 = 35184372088832,
        
        //unused
        D47 = 70368744177664,
        D48 = 140737488355328,
        D49 = 281474976710656,
        D50 = 562949953421312,

        //cold prep
        D51 = 1125899906842624,
        D52 = 2251799813685248,
        D53 = 4503599627370496,
        D54 = 9007199254740992,
        D55 = 18014398509481984,
        D56 = 36028797018963968,
        D57 = 72057594037927936,
        D58 = 144115188075855872,

        //unused
        D59 = 288230376151711744,
        D60 = 576460752303423488,

        //material handling
        D61 = 1152921504606846976,
    }
}
