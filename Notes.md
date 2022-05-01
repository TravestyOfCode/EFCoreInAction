# Notes and Questions for EF Core In Action

## Chapter 01

### **Notes**

EF Core uses transactions as every update is done as an *Atomic Unit*.

### **Questions**

* If we include AsNoTracking can we still save changes?
* Does change tracking make updates faster than sending over all of the column data (perhaps with large tables)?

---

## Chapter 02

### **Notes**
Make an `IQueryable<T>` to encapsulate the mapping of a DTO (which is called the *Query Object Pattern*).
```csharp
public static IQueryable<BookListDTO> MapBookToDTO(this IQueryable<Book> books)
{
    return books.Select(p => new BookListDTO()
    {
        BookId = p.BookId,
        Title = p.Title,
        Price = p.Price,
        // etc ...
    });
}
```

**Layered Architecture** is an approach to break the application into separate concerns. This can be done with separate projects in a solution (though Data Store and Data Layer usually same project):
* Data Store (SQL Server)
* Data Layer (Data Access, EF Core Classes/DBContext)
* Service Layer (Adapters/Mappers, Queries, Commands)
* WebApp (Controllers/ViewModels/Views/Areas)

*An example naming of a solution: App.Data, App.Services, App.Web, App.API*

### **Questions**
If using CQRS, could we have the Request implement some interface to generate the query. The pipeline can then addon to the query as needed.

```csharp
public IQueryable<DTO> Query {get;set;}}
// Pipeline Behaviours //
// Select
this.Query = this.Query.Select(p => new DTO() { /* mappings go here */ });
```

# Chapter 03

# Chapter 04

### **Notes**

Keeping business logic code separate from your domain classes is known as *transactions script* or the *procedural pattern* (via Eric Evans of Domain Driven Design?).

Guidelines for building business logic that uses EF Core:
* Business Logic defines how the database is structured.
* Business Logic should be separated from other application layers (like presentation).
* Business Logic should think it's working on in-memory data.
* Isolate the database access code into a separate project.
* Business Logic should not call the *SaveChanges* directly.

Because real-world applications that interact with humans, and we want to provide a good user experience, sometimes the business logic may move outside of the BL Layer, typically the presentation layer.

Three types of business rule parts:
* Manipulation of state or data (ex. Creating/Modifying an order)
* Validation rules
* Sequence or flow


