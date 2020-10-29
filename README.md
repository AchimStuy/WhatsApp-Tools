# WhatsApp-Tools
Export WhatsApp Chats from iTunes Backup to XML and render as HTML.

##### Exported XML:

```xml
<?xml version="1.0" encoding="utf-8"?>
<?xml-stylesheet type ="text/xsl" href="Render-Chat-as-HTML.xslt"?>
<Chat xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <Contact>491234567890</Contact>
  <Messages>
    <Message>
      <IsFromMe>1</IsFromMe>
      <MessageType>0</MessageType>
      <Starred>1</Starred>
      <MessageDate>2020-09-29T11:16:42+02:00</MessageDate>
      <Text>Hallo, World! 😊</Text>
      <ToJId>491234567890@s.whatsapp.net</ToJId>
    </Message>
    <Message>
      <IsFromMe>0</IsFromMe>
      <MessageType>0</MessageType>
      <Starred xsi:nil="true" />
      <MessageDate>2020-10-11T18:20:02+02:00</MessageDate>
      <FromJId>491234567890@s.whatsapp.net</FromJId>
      <Text>Hello, back! 🤗</Text>
    </Message>
  </Messages>
</Chat>
```

## Prerequisites

Chats are being exported from _ChatStorage.sqlite_, which can be obtained for example through [WazzapMigrator](https://www.wazzapmigrator.com/faq/windows-how-extract-chatstoragesqlite?multilink=switch).

## Usage

```
$> WhatsAppTools.Console export /Path/to/ChatStorage.sqlite 49123456789
```

This will create `49123456789.xml` next to _ChatStorage.sqlite_. Opening the created XML-File in Browser will apply the Stylesheet, which renders your Chats readably.

## Links

[WhatsApp-Elixir](https://github.com/borun/WhatsApp-Elixir) is a Windows desktop application based on [Securcube-WhatsApp-Viewer](https://github.com/impersoft/Securcube-Whatsapp-Viewer), with which you can view and search a WhatsApp backup. I found it after finishing my work on my WhatsApp-Tools.
