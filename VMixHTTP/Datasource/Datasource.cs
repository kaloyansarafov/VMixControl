namespace VMixHTTP.Datasource;

public class Datasource
{
    internal static string DataSourceAutoNextOff(string datasourceName, string table)
    {
        datasourceName = Uri.EscapeDataString(datasourceName);
        table = Uri.EscapeDataString(table);
        return $"Function=DataSourceAutoNextOff&Value={datasourceName},{table}";
    }
    
    internal static string DataSourceAutoNextOn(string datasourceName, string table)
    {
        datasourceName = Uri.EscapeDataString(datasourceName);
        table = Uri.EscapeDataString(table);
        return $"Function=DataSourceAutoNextOn&Value={datasourceName},{table}";
    }
    
    internal static string DataSourceAutoNextOnOff(string datasourceName, string table)
    {
        datasourceName = Uri.EscapeDataString(datasourceName);
        table = Uri.EscapeDataString(table);
        return $"Function=DataSourceAutoNextOnOff&Value={datasourceName},{table}";
    }
    
    internal static string DataSourceNextRow(string datasourceName, string table)
    {
        datasourceName = Uri.EscapeDataString(datasourceName);
        table = Uri.EscapeDataString(table);
        return $"Function=DataSourceNextRow&Value={datasourceName},{table}";
    }
    
    internal static string DataSourcePause(string datasourceName, string table)
    {
        datasourceName = Uri.EscapeDataString(datasourceName);
        table = Uri.EscapeDataString(table);
        return $"Function=DataSourcePause&Value={datasourceName},{table}";
    }
    
    internal static string DataSourcePlay(string datasourceName, string table)
    {
        datasourceName = Uri.EscapeDataString(datasourceName);
        table = Uri.EscapeDataString(table);
        return $"Function=DataSourcePlay&Value={datasourceName},{table}";
    }
    
    internal static string DataSourcePlayPause(string datasourceName, string table)
    {
        datasourceName = Uri.EscapeDataString(datasourceName);
        table = Uri.EscapeDataString(table);
        return $"Function=DataSourcePlayPause&Value={datasourceName},{table}";
    }
    
    internal static string DataSourcePreviousRow(string datasourceName, string table)
    {
        datasourceName = Uri.EscapeDataString(datasourceName);
        table = Uri.EscapeDataString(table);
        return $"Function=DataSourcePreviousRow&Value={datasourceName},{table}";
    }
    
    internal static string DataSourceSelectRow(string datasourceName, string table, int index, int rowNumber = -1, int n = -1)
    {
        datasourceName = Uri.EscapeDataString(datasourceName);
        table = Uri.EscapeDataString(table);
        
        if (rowNumber == -1 && n == -1)
            return $"Function=DataSourceSelectRow&Value={datasourceName},{table},{index}";
        if (rowNumber != -1 && n == -1)
            return $"Function=DataSourceSelectRow&Value={datasourceName},{table},{index},{rowNumber}";
        
        return $"Function=DataSourceSelectRow&Value={datasourceName},{table},{index},{rowNumber},{n}";
    }
}