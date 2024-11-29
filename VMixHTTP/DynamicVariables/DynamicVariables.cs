namespace VMixHTTP.DynamicVariables;

public class DynamicVariables
{
    internal static string SetDynamicInput1(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=SetDynamicInput1&Value={input}";
    }
    
    internal static string SetDynamicInput2(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=SetDynamicInput2&Value={input}";
    }
    
    internal static string SetDynamicInput3(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=SetDynamicInput3&Value={input}";
    }
    
    internal static string SetDynamicInput4(string input)
    {
        input = Uri.EscapeDataString(input);
        return $"Function=SetDynamicInput4&Value={input}";
    }
    
    internal static string SetDynamicValue1(string value)
    {
        value = Uri.EscapeDataString(value);
        return $"Function=SetDynamicValue1&Value={value}";
    }
    
    internal static string SetDynamicValue2(string value)
    {
        value = Uri.EscapeDataString(value);
        return $"Function=SetDynamicValue2&Value={value}";
    }
    
    internal static string SetDynamicValue3(string value)
    {
        value = Uri.EscapeDataString(value);
        return $"Function=SetDynamicValue3&Value={value}";
    }
    
    internal static string SetDynamicValue4(string value)
    {
        value = Uri.EscapeDataString(value);
        return $"Function=SetDynamicValue4&Value={value}";
    }
}