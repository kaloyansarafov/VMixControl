using System.Globalization;

namespace VMixHTTP.Effects;

public class Effects
{
    internal static string Effect1(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect1&Input={input}";
    }
    
    internal static string Effect1Off(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect1Off&Input={input}";
    }
    
    internal static string Effect1On(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect1On&Input={input}";
    }
    
    internal static string Effect2(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect2&Input={input}";
    }
    
    internal static string Effect2Off(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect2Off&Input={input}";
    }
    
    internal static string Effect2On(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect2On&Input={input}";
    }
    
    internal static string Effect3(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect3&Input={input}";
    }
    
    internal static string Effect3Off(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect3Off&Input={input}";
    }
    
    internal static string Effect3On(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect3On&Input={input}";
    }
    
    internal static string Effect4(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect4&Input={input}";
    }
    
    internal static string Effect4Off(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect4Off&Input={input}";
    }
    
    internal static string Effect4On(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Effect4On&Input={input}";
    }
    
    internal static string SetEffect1Strength(string input, double strength)
    {
        strength = Math.Clamp(strength, 0, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetEffect1Strength&Input={input}&Value={strength.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetEffect2Strength(string input, double strength)
    {
        strength = Math.Clamp(strength, 0, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetEffect2Strength&Input={input}&Value={strength.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetEffect3Strength(string input, double strength)
    {
        strength = Math.Clamp(strength, 0, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetEffect3Strength&Input={input}&Value={strength.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetEffect4Strength(string input, double strength)
    {
        strength = Math.Clamp(strength, 0, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetEffect4Strength&Input={input}&Value={strength.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetFrameDelay(string input, double delay)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=SetFrameDelay&Input={input}&Value={delay.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
}