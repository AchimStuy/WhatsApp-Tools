using System;
using System.ComponentModel.DataAnnotations;
using System.IO;

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

        int OnExecute(IConsole console)
        {
            try
            {
                new Core.WhatsAppTools(new FileInfo(ChatStoragePath)).Export(Contact);
                return 0;
            }
            catch (Exception exc)
            {
                console.Error.WriteLine(exc.Message);
                return -1;
            }
        }
    }
}
