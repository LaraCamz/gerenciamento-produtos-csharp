using System.Collections.Generic;

public class SistemaLogs
{
    public IEnumerable<string> LerLogsMacicos()
    {
        for (int i = 1; i <= 5000000; i++)
        {
            yield return $"Registro de log {i}";
        }
    }
}