using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace WhatsAppTools.Core
{
    public class WhatsAppTools
    {
        public FileInfo ChatStorageFile { get; }

        public WhatsAppTools(FileInfo chatStorageFile)
        {
            if (!chatStorageFile.Exists)
                throw new FileNotFoundException(null, chatStorageFile.FullName);

            ChatStorageFile = chatStorageFile;
        }

        public void Export(string contact)
        {
            using var chatStorage = new iOS.ChatStorageContext(ChatStorageFile);
            var messages = chatStorage.Messages
                .Where(m => m.FromJId.StartsWith(contact) || m.ToJId.StartsWith(contact)).ToArray();

            var exportFile = new FileInfo(Path.Combine(ChatStorageFile.DirectoryName, $"{contact}.xml"));
            using var xmlWriter = XmlWriter.Create(exportFile.FullName, new XmlWriterSettings { Indent = true });
            new XmlSerializer(typeof(Chat)).Serialize(xmlWriter, new Chat { Contact = contact, Messages = messages });
        }
    }
}
