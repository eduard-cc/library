# Library - by Eduard

With this app it is possible to:
* Add and remove books
* Add and remove members
* Search for books based on 3 filters: title, author and genre (which can be combined together)
* View a book's details and history of loans
* Register when a book has been borrowed and by whom
* Register when a borrowed book has been returned
---
All object data is saved and loaded using XML.

When the app is launched:
* All data in books.xml is deserialized into the List<Book> Books
* All data in members.xml is deserialized into the List<Member> Members
* If a file named books.xml or members.xml doesn't exist, it is created, included with 3 hardcoded books/members for demonstration purposes

Every time a change to a list is made (such as a book is added/removed), the change is serialized to it's respective xml file.