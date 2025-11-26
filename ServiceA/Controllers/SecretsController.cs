using Dapr.Client;
using Microsoft.AspNetCore.Mvc;

namespace ServiceA.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SecretsController(
    DaprClient daprClient,
    ILogger<SecretsController> logger) : ControllerBase
{
    [HttpGet("read")]
    public async Task<IActionResult> ReadSecret(string key)
    {
        var secrets = await daprClient.GetSecretAsync("secretstore", key);
        var value = secrets[key];

        return Ok(value);
    }
}
