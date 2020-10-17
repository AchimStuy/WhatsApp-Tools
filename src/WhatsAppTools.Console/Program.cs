using McMaster.Extensions.CommandLineUtils;

namespace WhatsAppTools.Console
{
    [Subcommand(typeof(ExportCommand))]
    public class Program
    {
        static int Main(string[] args)
            => CommandLineApplication.Execute<Program>(args);

        int OnExecute(CommandLineApplication app)
        {
            app.ShowHelp();
            return 1;
        }
    }
}
