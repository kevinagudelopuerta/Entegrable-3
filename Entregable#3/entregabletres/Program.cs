using entregabletres.Entreble;
using entregabletres.Libros;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//            -- Libros --          //

List<LibrosDTO> B = new List<LibrosDTO>();
LibrosHandler handlerr = new LibrosHandler(B);

//            -- Autores --          // 

List<AutoresDTO> BD = new List<AutoresDTO>();
AutoresHandler handler = new AutoresHandler(BD);

//            -- Autores --          //

app.MapPost("/api/v1/autores", (AutoresDTO autores) => {
    handler.create(autores); 
});                                                             
            
//            -- Libros --          //
app.MapPost("/api/v1/libros", (LibrosDTO libros) => {
    handlerr.create(libros);
});

//            -- Autores --          //
app.MapPut("/api/v1/autores/{id:guid}", (Guid id, AutoresDTO autores) => {
     handler.update(autores, id);
});

//            -- Libros --          //
app.MapPut("/api/v1/libros/{id:guid}", (Guid id, LibrosDTO libros) => {
     handlerr.update(libros, id);
});

//            -- Autores --          //
app.MapGet("/api/v1/autores", () => {
    return Results.Ok(handler.All());
});

//            -- Libros --          //
app.MapGet("/api/v1/libros", () => {
    return Results.Ok(handlerr.All());
});

//            -- Autores --          //
app.MapDelete("/api/v1/autores/{id:guid}", (Guid id) => {
     handler.delete(id);
});

//            -- Libros --          //
app.MapDelete("/api/v1/libros/{id:guid}", (Guid id) => {
     handlerr.delete(id);
});

app.Run();


