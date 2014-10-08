using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
namespace PKMDS
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [Serializable()]
    public class PK6
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 232)]
        [Browsable(false)]
        protected byte[] Data;
        public PK6()
        {
            Data = new byte[232];
        }
        public void CalcChecksum()
        {
            /*
             The checksum is calculated in three steps:

             Split the unencrypted data from offsets 0x08 to 0xE7 into two-byte words,
             Take the sum of the words, and
             Truncate the sum to 16 bits.
             */
            UInt32 sum = 0;
            for (int i = 0x08; i < 0xE8; i += 2) 
            {
                sum += BitConverter.ToUInt16(Data, i);
            }
            Checksum = (UInt16)(sum & 0xFF);
        }
        protected UInt32 EK
        {
            get
            {
                return BitConverter.ToUInt32(Data, 0x00);
            }
            set
            {
                byte[] bytes = BitConverter.GetBytes(value);
                Array.Copy(bytes, 0, Data, 0x00, 4);
            }
        }
        protected UInt16 Checksum
        {
            get
            {
                return BitConverter.ToUInt16(Data, 0x06);
            }
            set
            {
                byte[] bytes = BitConverter.GetBytes(value);
                Array.Copy(bytes, 0, Data, 0x06, 2);
            }
        }
        public UInt16 TID
        {
            get
            {
                return BitConverter.ToUInt16(Data, 0x0C);
            }
            set
            {
                byte[] bytes = BitConverter.GetBytes(value);
                Array.Copy(bytes, 0, Data, 0x0C, 2);
            }
        }
        public UInt16 SID
        {
            get
            {
                return BitConverter.ToUInt16(Data, 0x0E);
            }
            set
            {
                byte[] bytes = BitConverter.GetBytes(value);
                Array.Copy(bytes, 0, Data, 0x0E, 2);
            }
        }
        public Boolean OTIsFemale
        {
            get
            {
                return ((((Data[0xDD]) & (byte)0x80) >> 7) == 1);
            }
            set
            {
                if (value)
                {
                    Data[0xDD] = (byte)(Data[0xDD] | (byte)0x80);
                }
                else
                {
                    Data[0xDD] = (byte)(Data[0xDD] & (byte)0x7F);
                }
            }
        }
        public String OTName
        {
            get
            {
                return System.Text.Encoding.Unicode.GetString(Data, 0xB0, 0x18);
            }
            set
            {
                if (value.Length > 12)
                {
                    value = value.Substring(0, 12);
                }
                byte[] bytes = System.Text.Encoding.Unicode.GetBytes(value);
                Array.Copy(bytes, 0, Data, 0xB0, bytes.Length);
            }
        }
    }
}
