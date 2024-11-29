using System.Globalization;

namespace VMixHTTP.ColourCorrection;

internal class ColourCorrection
{
    internal static string ColourCorrectionAuto(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=ColourCorrectionAuto&Input={input}";
    }
    
    internal static string ColourCorrectionReset(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=ColourCorrectionReset&Input={input}";
    }
    
    internal static string SetAlpha(string input, int alpha)
    {
        alpha = Math.Clamp(alpha, 0, 255);
        input = Uri.EscapeDataString(input);
        return $"Function=SetAlpha&Input={input}&Value={alpha}";
    }
    
    internal static string SetCCGainB(string input, double gain)
    {
        gain = Math.Clamp(gain, 0, 2);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCGainBlue&Input={input}&Value={gain.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCGainG(string input, double gain)
    {
        gain = Math.Clamp(gain, 0, 2);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCGainGreen&Input={input}&Value={gain.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCGainR(string input, double gain)
    {
        gain = Math.Clamp(gain, 0, 2);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCGainRed&Input={input}&Value={gain.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCGainRGB(string input, double gain)
    {
        gain = Math.Clamp(gain, 0, 2);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCGainRGB&Input={input}&Value={gain.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCGainY(string input, double gain)
    {
        gain = Math.Clamp(gain, 0, 2);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCGainYellow&Input={input}&Value={gain.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCGammaB(string input, double gamma)
    {
        gamma = Math.Clamp(gamma, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCGammaBlue&Input={input}&Value={gamma.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCGammaG(string input, double gamma)
    {
        gamma = Math.Clamp(gamma, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCGammaGreen&Input={input}&Value={gamma.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCGammaR(string input, double gamma)
    {
        gamma = Math.Clamp(gamma, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCGammaRed&Input={input}&Value={gamma.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCGammaRGB(string input, double gamma)
    {
        gamma = Math.Clamp(gamma,-1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCGammaRGB&Input={input}&Value={gamma.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCGammaY(string input, double gamma)
    {
        gamma = Math.Clamp(gamma, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCGammaYellow&Input={input}&Value={gamma.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCHue(string input, double hue)
    {
        hue = Math.Clamp(hue, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCHue&Input={input}&Value={hue.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCLiftB(string input, double lift)
    {
        lift = Math.Clamp(lift, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCLiftBlue&Input={input}&Value={lift.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCLiftG(string input, double lift)
    {
        lift = Math.Clamp(lift, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCLiftGreen&Input={input}&Value={lift.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCLiftR(string input, double lift)
    {
        lift = Math.Clamp(lift, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCLiftRed&Input={input}&Value={lift.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCLiftRGB(string input, double lift)
    {
        lift = Math.Clamp(lift, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCLiftRGB&Input={input}&Value={lift.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCLiftY(string input, double lift)
    {
        lift = Math.Clamp(lift, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCLiftYellow&Input={input}&Value={lift.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
    
    internal static string SetCCSaturation(string input, double saturation)
    {
        saturation = Math.Clamp(saturation, -1, 1);
        input = Uri.EscapeDataString(input);
        return $"Function=SetCCSaturation&Input={input}&Value={saturation.ToString("0.0", CultureInfo.InvariantCulture)}";
    }
}