module Biblioteka =

    type Contact = {
        Email : string
        Phone : string
    }

    type Person = {
        Name : string
        contact : Contact
    }

    type Authors = Name of string | Names of list<string>

    type Edition = | First | Second | Third | Fourth | Fifth | Sixth | Seventh | Eighth | Ninth | Tenth

    type Category = string

    /// Information about a book
    type BookTitle = {
        Title : string 
        Author : Authors
        ISBN : string
        pages : int
        publisher : string
        // year of publication
        published : int
        edition : Edition
        description : option<string>
        categories : list<Category>
        language : string
        translator : option<string>
    }

    /// Book has a condition
    type BookCondition = | New | Good | Worn | Damaged

    /// Instance of a book
    type Book = {
        Title : BookTitle
        Condition: BookCondition 
        Owner : Person
    }

    type Lend = {
        Book : Book
        Borrower : Person
        Date : System.DateTime
        ReturnDate : System.DateTime
    }


    let bookTitles = [
        { Title = "The Art of Computer Programming"
          Author = Names ["Donald E. Knuth"]
          ISBN = "978-0-201-89683-1"
          pages = 7000
          publisher = "Addison-Wesley"
          published = 1968
          edition = First
          description = Some "The Art of Computer Programming is a comprehensive monograph written by Donald E. Knuth that covers many kinds of programming algorithms and their analysis."
          categories = ["Computer Science"; "Programming"]
          language = "English"
          translator = None
        }
        { Title = "The C Programming Language"
          Author = Names ["Brian W. Kernighan"; "Dennis M. Ritchie"]
          ISBN = "978-0-13-110362-7"
          pages = 228
          publisher = "Prentice Hall"
          published = 1978
          edition = First
          description = Some "The C Programming Language is a computer programming book written by Brian W. Kernighan and Dennis M. Ritchie, the latter of whom originally designed and implemented the language, as well as co-designed the Unix operating system with which development of the language was closely intertwined."
          categories = ["Computer Science"; "Programming"]
          language = "English"
          translator = None
        }
        {   Title = "The Mythical"
            Author = Name "Sisyphus"
            ISBN = "978-0-00-000000-0"
            pages = 1
            publisher = "The Publisher"
            published = 2021
            edition = First
            description = Some "The Mythical is a book about the myth of Sisyphus."
            categories = ["Philosophy"]
            language = "English"
            translator = None
        }
        {   Title = "Crime And Punishment"
            Author = Name "Fyodor Dostoevsky"
            ISBN = "978-0-00-000000-0"
            pages = 1
            publisher = "The Publisher"
            published = 1866
            edition = First
            description = Some "Crime and Punishment is a novel by the Russian author Fyodor Dostoevsky. It was first published in the literary journal The Russian Messenger in twelve monthly installments during 1866."
            categories = ["Philosophy"]
            language = "Russian"
            translator = Some "Constance Garnett"

        }
    ]

    let persons = [
        { Name = "John Doe"
          contact = { Email = "johnd@gmail.com"; Phone = "123-456-789" }}
        { Name = "Jane Doe"
          contact = { Email = "janed@yahoo.com"; Phone = "987-654-321" }}
        { Name = "John Smith"
          contact = { Email = "jsmith@hotmail.com"; Phone = "111-222-333" }}
    ]

    let library = [
        { Title = bookTitles.[0]
          Condition = New
          Owner = persons.[0] }
        { Title = bookTitles.[0]
          Condition = New
          Owner = persons.[1] }
        { Title = bookTitles.[1]
          Condition = Good
          Owner = persons.[1] }
        { Title = bookTitles.[2]
          Condition = Worn
          Owner = persons.[2] }
        { Title = bookTitles.[3]
          Condition = Damaged
          Owner = persons.[0] }
    ]   

    let lendings = [
        { Book = library.[0]
          Borrower = persons.[1]
          Date = System.DateTime(2021, 1, 1)
          ReturnDate = System.DateTime(2021, 1, 31) }
        { Book = library.[1]
          Borrower = persons.[2]
          Date = System.DateTime(2021, 1, 1)
          ReturnDate = System.DateTime(2021, 1, 31) }
        { Book = library.[2]
          Borrower = persons.[0]
          Date = System.DateTime(2021, 1, 1)
          ReturnDate = System.DateTime(2021, 1, 31) }
        { Book = library.[3]
          Borrower = persons.[1]
          Date = System.DateTime(2021, 1, 1)
          ReturnDate = System.DateTime(2021, 1, 31) }
    ]   

    let getBooksByAuthor author = 
        library
        |> List.filter (fun book -> 
            match book.Title.Author with
            | Name name -> name = author
            | Names names -> names |> List.exists (fun name -> name = author))


    let getBookTitlesOfBooks (books) = 
        books
        |> List.map (fun book -> book.Title)
        |> List.distinct
        
    let getTitlesByAuthor author = 
        library
        |> List.filter (fun book  -> 
            match book.Title.Author with
            | Name name -> name = author
            | Names names -> names |> List.exists (fun name -> name = author))
        |> List.map (fun book -> book.Title.Title)

open Biblioteka
//printfn "%A" ( getBooksByAuthor "Donald E. Knuth" )
//printfn "%A" ( getTitlesByAuthor "Donald E. Knuth" )
printfn "%A" ( getBookTitlesOfBooks Biblioteka.library)
