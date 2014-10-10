using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.IO;
namespace PKMDS
{
    public static class Functions
    {
        public static PK6 ReadPK6(String FileName)
        {
            PK6 pk6 = new PK6();
            byte[] data;
            using (FileStream fs = new FileStream(FileName, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    data = br.ReadBytes((int)fs.Length);
                    br.Close();
                    fs.Close();
                }
            }
            pk6 = (PK6)(PKMDS.Serializer.RawDeserialize(data, typeof(PK6)));
            return pk6;
        }
        public static void WritePK6(PK6 pk6, String FileName)
        {
            byte[] data = Serializer.RawSerialize(pk6);
            using (FileStream fs = new FileStream(FileName, FileMode.Create, FileAccess.Write))
            {
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(data, 0, 0xE8);
                    bw.Close();
                    fs.Close();
                }
            }
        }
    }
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [Serializable()]
    public struct PK6
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 0xE8)]
        [Browsable(false)]
        private byte[] Data;
        public void CalcChecksum()
        {
            UInt32 sum = 0;
            for (int i = 0x08; i < 0xE7; i += 2)
            {
                sum += BitConverter.ToUInt16(Data, i);
            }
            Checksum = (UInt16)(sum & 0xFFFF);
        }
        private UInt32 EK
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
        private UInt16 Checksum
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
                Array.Clear(Data, 0xB0, 24);
                Array.Copy(bytes, 0, Data, 0xB0, bytes.Length);
            }
        }
    }
}
