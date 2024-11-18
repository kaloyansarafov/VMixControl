namespace VMixHTTP.Audio;

internal static class Audio
{
    internal static string AudioMuteUnmute(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=Audio&Input={input}";
    }

    internal static string AudioAuto(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioAuto&Input={input}";
    }

    internal static string AudioAutoOff(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioAutoOff&Input={input}";
    }

    internal static string AudioAutoOn(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioAutoOn&Input={input}";
    }
    
    internal static string AudioBus(string input, string bus)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioBus&Input={input}&Value={bus}";
    }
    
    internal static string AudioBusOff(string input, string bus)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioBusOff&Input={input}&Value={bus}";
    }
    
    internal static string AudioBusOn(string input, string bus)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioBusOn&Input={input}&Value={bus}";
    }
    
    internal static string AudioChannelApplyMatrixPreset(string input, string preset)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioChannelApplyMatrixPreset&Input={input}&Value={preset}";
    }
    
    internal static string AudioMixerShowHide()
    {
        return "Function=AudioMixerShowHide";
    }
    
    internal static string AudioOff(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioOff&Input={input}";
    }
    
    internal static string AudioOn(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioOn&Input={input}";
    }
    
    internal static string AudioPluginOn(string input, string pluginNumber)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioPluginOn&Input={input}&Value={pluginNumber}";
    }
    
    internal static string AudioPluginOff(string input, string pluginNumber)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioPluginOff&Input={input}&Value={pluginNumber}";
    }
    
    internal static string AudioPluginOnOff(string input, string pluginNumber)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioPluginOnOff&Input={input}&Value={pluginNumber}";
    }
    
    internal static string AudioPluginShow(string input, string pluginNumber)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=AudioPluginShow&Input={input}&Value={pluginNumber}";
    }

    internal static string BusAAudio()
    {
        return "Function=BusAAudio";
    }
    
    internal static string BusAAudioOff()
    {
        return "Function=BusAAudioOff";
    }
    
    internal static string BusAAudioOn()
    {
        return "Function=BusAAudioOn";
    }

    internal static string BusAAudioPluginOff()
    {
        return "Function=BusAAudioPluginOff";
    }
    
    
}