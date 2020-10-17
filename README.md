# WhatsApp-Tools
Export WhatsApp Chats from iTunes Backup to XML and render as HTML.

## Prerequisites

Chats are being exported from _ChatStorage.sqlite_, which can be obtained for example through [WazzapMigrator](https://www.wazzapmigrator.com/faq/windows-how-extract-chatstoragesqlite?multilink=switch).

## Usage

```
$> WhatsAppTools.Console export /Path/to/ChatStorage.sqlite 49123456789
```

This will create `49123456789.xml` next to _ChatStorage.sqlite_. Opening the created XML-File in Browser will apply the Stylesheet, which renders your Chats readably.
