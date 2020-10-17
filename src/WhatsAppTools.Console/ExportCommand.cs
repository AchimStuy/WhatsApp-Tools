using System.ComponentModel.DataAnnotations;

using McMaster.Extensions.CommandLineUtils;

namespace WhatsAppTools.Console
{
    [Command(Description = "Export ChatStorage.sqlite to XML")]
    class ExportCommand
    {
        [Argument(0, Description = "Path to ChatStorage.sqlite")]
        [Required]
        public string ChatStoragePath { get; set; }

        [Argument(1, Description = "The Phone Number of the Chat to export in the form '491234567890'")]
        [Required]
        public string Contact { get; set; }

        int OnExecute()
        {
            return 0;
        }
    }
}
