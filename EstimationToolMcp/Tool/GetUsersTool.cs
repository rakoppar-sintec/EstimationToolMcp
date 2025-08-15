using EstimationToolMcp.Service;
using ModelContextProtocol.Server;
using System.ComponentModel;

[McpServerToolType]
public class GetUsersTool
{
    [McpServerTool, Description("Get the estimation tool users")]
    public static async Task<string> GetUsers(IUserService userService)
    {
        return await userService.GetUsersAsync();        
    }
}
