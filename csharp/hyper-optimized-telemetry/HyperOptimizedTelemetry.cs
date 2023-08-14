using System;

public static class TelemetryBuffer
{
     // Enum to represent the number of bytes for different types
    public enum ByteCounts
    {
        Long = 8,
        Integer = 4,
        Short = 2
    }

    // Encode a long value into a telemetry buffer
    public static byte[] ToBuffer(long value)
    {
        var bufferBytes = new byte[9];
        byte[] valueBytes;

        if (value > UInt32.MaxValue || value < Int32.MinValue)
        {
            bufferBytes[0] = (byte)(256 - (byte)ByteCounts.Long); // Set the prefix byte for long
            valueBytes = BitConverter.GetBytes(value);
            Array.Copy(valueBytes, 0, bufferBytes, 1, valueBytes.Length); // Copy payload bytes after the prefix
        }
        else if (value > Int32.MaxValue)
        {
            bufferBytes[0] = (byte)ByteCounts.Integer; // Set the prefix byte for unsigned int
            valueBytes = BitConverter.GetBytes((uint)value);
            Array.Copy(valueBytes, 0, bufferBytes, 1, valueBytes.Length);
        }
        else if (value > UInt16.MaxValue || value < Int16.MinValue)
        {
            bufferBytes[0] = (byte)(256 - (byte)ByteCounts.Integer); // Set the prefix byte for signed int
            valueBytes = BitConverter.GetBytes((int)value);
            Array.Copy(valueBytes, 0, bufferBytes, 1, valueBytes.Length);
        }
        else if (value >= Int16.MaxValue && value <= UInt16.MaxValue)
        {
            bufferBytes[0] = (byte)ByteCounts.Short; // Set the prefix byte for ushort
            valueBytes = BitConverter.GetBytes((short)value);
            Array.Copy(valueBytes, 0, bufferBytes, 1, valueBytes.Length);
        }
        else if (value > 0)
        {
            bufferBytes[0] = (byte)(256 - (byte)ByteCounts.Short); // Set the prefix byte for positive short
            valueBytes = BitConverter.GetBytes((short)value);
            Array.Copy(valueBytes, 0, bufferBytes, 1, valueBytes.Length);
        }
        else if (value == 0)
        {
            bufferBytes[0] = (byte)ByteCounts.Short; // Set the prefix byte for zero
            valueBytes = BitConverter.GetBytes((short)value);
            Array.Copy(valueBytes, 0, bufferBytes, 1, valueBytes.Length);
        }
        else
        {
            bufferBytes[0] = (byte)(256 - (byte)ByteCounts.Short); // Set the prefix byte for negative short
            valueBytes = BitConverter.GetBytes((short)value);
            Array.Copy(valueBytes, 0, bufferBytes, 1, valueBytes.Length);
        }

        return bufferBytes;
    }

    // Decode a telemetry buffer and return the long value
    public static long FromBuffer(byte[] buffer)
    {
        sbyte prefixByte = (sbyte)buffer[0];

        if (prefixByte == -8)
            return BitConverter.ToInt64(buffer, 1); // Decode long
        else if (prefixByte == 4)
            return BitConverter.ToUInt32(buffer, 1); // Decode unsigned int
        else if (prefixByte == -4)
            return BitConverter.ToInt32(buffer, 1); // Decode int
        else if (prefixByte == 2)
            return BitConverter.ToUInt16(buffer, 1); // Decode ushort
        else if (prefixByte == -2)
            return BitConverter.ToInt16(buffer, 1); // Decode short
        else
            return 0; // Default case: invalid prefix byte
    }
}