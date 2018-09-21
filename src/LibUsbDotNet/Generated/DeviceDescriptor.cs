//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright © 2006-2010 Travis Robinson. All rights reserved.
// Copyright © 2011-2018 LibUsbDotNet contributors. All rights reserved.
// 
// website: http://github.com/libusbdotnet/libusbdotnet
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the
// Free Software Foundation; either version 2 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
// for more details.
// 
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. or 
// visit www.gnu.org.
// 
//

using System;
using System.Runtime.InteropServices;

namespace LibUsbDotNet
{
    /// <summary>
    ///  A structure representing the standard USB device descriptor. This
    ///  descriptor is documented in section 9.6.1 of the USB 3.0 specification.
    ///  All multiple-byte fields are represented in host-endian format.
    /// </summary>
    [StructLayoutAttribute(LayoutKind.Sequential, Pack = NativeMethods.Pack)]
    public struct DeviceDescriptor
    {
        /// <summary>
        ///  Size of this descriptor (in bytes)
        /// </summary>
        public byte Length;

        /// <summary>
        ///  Descriptor type. Will have value
        ///  context.
        /// </summary>
        public byte DescriptorType;

        /// <summary>
        ///  USB specification release number in binary-coded decimal. A value of
        ///  0x0200 indicates USB 2.0, 0x0110 indicates USB 1.1, etc.
        /// </summary>
        public ushort USB;

        /// <summary>
        ///  USB-IF class code for the device. See
        /// </summary>
        public byte DeviceClass;

        /// <summary>
        ///  USB-IF subclass code for the device, qualified by the bDeviceClass
        ///  value
        /// </summary>
        public byte DeviceSubClass;

        /// <summary>
        ///  USB-IF protocol code for the device, qualified by the bDeviceClass and
        ///  bDeviceSubClass values
        /// </summary>
        public byte DeviceProtocol;

        /// <summary>
        ///  Maximum packet size for endpoint 0
        /// </summary>
        public byte MaxPacketSize0;

        /// <summary>
        ///  USB-IF vendor ID
        /// </summary>
        public ushort IdVendor;

        /// <summary>
        ///  USB-IF product ID
        /// </summary>
        public ushort IdProduct;

        /// <summary>
        ///  Device release number in binary-coded decimal
        /// </summary>
        public ushort Device;

        /// <summary>
        ///  Index of string descriptor describing manufacturer
        /// </summary>
        public byte Manufacturer;

        /// <summary>
        ///  Index of string descriptor describing product
        /// </summary>
        public byte Product;

        /// <summary>
        ///  Index of string descriptor containing device serial number
        /// </summary>
        public byte SerialNumber;

        /// <summary>
        ///  Number of possible configurations
        /// </summary>
        public byte NumConfigurations;

    }
}