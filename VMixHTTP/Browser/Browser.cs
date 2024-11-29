namespace VMixHTTP.Browser;

internal class Browser
{
    internal static string BrowserBack(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=BrowserBack&Input={input}";
    }
    
    internal static string BrowserForward(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=BrowserForward&Input={input}";
    }

    internal static string BrowserKeyboardDisabled(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=BrowserKeyboardDisabled&Input={input}";
    }
    
    internal static string BrowserKeyboardEnabled(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=BrowserKeyboardEnabled&Input={input}";
    }
    
    internal static string BrowserMouseDisabled(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=BrowserMouseDisabled&Input={input}";
    }
    
    internal static string BrowserMouseEnabled(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=BrowserMouseEnabled&Input={input}";
    }
    
    internal static string BrowserNavigate(string input, string url)
    {
        input = Uri.EscapeDataString(input);
        url = Uri.EscapeDataString(url);
        return $"Function=BrowserNavigate&Input={input}&Value={url}";
    }
    
    internal static string BrowserReload(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=BrowserReload&Input={input}";
    }
}