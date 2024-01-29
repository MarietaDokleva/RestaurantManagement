using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public class CustomHealthCheck : IHealthCheck
{
    private readonly string _filePath;

    public CustomHealthCheck(string filePath)
    {
        _filePath = filePath;
    }

    public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
    {
        try
        {
            // Проверяваме дали файлът съществува
            if (File.Exists(_filePath))
            {
                return Task.FromResult(HealthCheckResult.Healthy($"File {_filePath} exists."));
            }
            else
            {
                return Task.FromResult(HealthCheckResult.Unhealthy($"File {_filePath} does not exist."));
            }
        }
        catch (Exception ex)
        {
            return Task.FromResult(HealthCheckResult.Unhealthy($"Health check failed for file {_filePath}: {ex.Message}"));
        }
    }
}
