// See https://aka.ms/new-console-template for more information

using Day4;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

DateTime pub = DateTime.Now;
Book b1 = new Book("H12JS8AJSH8SJA102S", "Harry Potter", new string[] {"J.K Rowling"}, pub, 500m);
Book b2 = new Book("BKS9ASJK8SAK", "Book", new string[] { "Author1", "Author2" }, DateTime.Now, 1000m);

List<Book> BookList = new();
BookList.Add(b1);
BookList.Add(b2);

//User Defined Delegate Datatype
BookDelegate fPtr = BookFunctions.GetPrice;
LibraryEngine.ProcessBooks(BookList, fPtr);

//BCL Delegates
Func<Book, string> fPtrBCL = book => book.Title;
LibraryEngine.ProcessBooks(BookList, fPtrBCL);

//Anonymous Function
fPtr = delegate(Book b) { return b.ISBN; };
LibraryEngine.ProcessBooks(BookList, fPtr);


//Lambda Expression
fPtr = b =>  b.PublicationDate.ToString();
LibraryEngine.ProcessBooks(BookList, fPtr);

