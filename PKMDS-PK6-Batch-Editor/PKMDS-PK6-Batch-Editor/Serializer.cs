/*
Copyright (c) 2004-2013 Thong Nguyen (tumtumtum@gmail.com), Platform.NET
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the Platform.NET nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL <COPYRIGHT HOLDER> BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

https://github.com/platformdotnet/Platform
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
namespace PKMDS
{
    class Serializer
    {
        /// <summary>
        /// Serializes a structure into raw bytes
        /// </summary>
        /// <param name="structure">The struture  to serialize</param>
        /// <returns></returns>
        public static byte[] RawSerialize<T>(T structure)
            where T : struct
        {
            return RawSerialize((object)structure);
        }
        /// <summary>
        /// Serializes a structure into raw bytes
        /// </summary>
        /// <param name="structure">The struture  to serialize</param>
        /// <returns></returns>
        public static byte[] RawSerialize(object structure)
        {
            var rawsize = Marshal.SizeOf(structure);
            var buffer = Marshal.AllocHGlobal(rawsize);

            Marshal.StructureToPtr(structure, buffer, false);
            var rawdata = new byte[rawsize];
            Marshal.Copy(buffer, rawdata, 0, rawsize);
            Marshal.FreeHGlobal(buffer);

            return rawdata;
        }
        /// <summary>
        /// Deserialize a structure from bytes
        /// </summary>
        /// <typeparam name="T">The type of the structure to deserialize</typeparam>
        /// <param name="rawdata">The data that makes up the structure</param>
        /// <returns>The deserialized structure</returns>
        public static T RawDeserialize<T>(byte[] rawdata)
            where T : struct
        {
            return (T)RawDeserialize(rawdata, typeof(T));
        }
        /// <summary>
        /// Deserialize a structure from bytes
        /// </summary>
        /// <typeparam name="type">The type of the structure to deserialize</typeparam>
        /// <param name="rawdata">The data that makes up the structure</param>
        /// <returns>The deserialized structure</returns>
        public static object RawDeserialize(byte[] rawdata, Type type)
        {
            var rawsize = Marshal.SizeOf(type);

            if (rawsize > rawdata.Length)
            {
                return null;
            }

            var buffer = Marshal.AllocHGlobal(rawsize);
            Marshal.Copy(rawdata, 0, buffer, rawsize);
            var retval = Marshal.PtrToStructure(buffer, type);
            Marshal.FreeHGlobal(buffer);

            return retval;
        }
    }
}
