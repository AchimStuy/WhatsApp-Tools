using McMaster.Extensions.CommandLineUtils;

namespace WhatsAppTools.Console
{
    [Command(Description = "Show Version Information")]
    class VersionCommand
    {
        int OnExecute(IConsole console)
        {
            console.WriteLine(typeof(VersionCommand).Assembly.GetName().Version);
            return 0;
        }
    }
}
