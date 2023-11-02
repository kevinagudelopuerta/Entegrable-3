namespace entregabletres.Libros;

public class LibrosHandler
{
    private List<LibrosDTO> _libros;

    public LibrosHandler(List<LibrosDTO> libros)
    {
         this._libros = libros;
   }

   public List<LibrosDTO> All(){
    return this._libros;
   }

   //metodo para crear
   public void create(LibrosDTO libros)
   {
    this._libros.Add(libros);
   }

   //metodo para actualizar
   public void update(LibrosDTO libros,Guid id)
   {
    var librosE = this._libros.FirstOrDefault(libros => libros.id == id);
 
    foreach (LibrosDTO dto in this._libros)
    {
       if (dto.id == id){
        dto.titulo = libros.titulo;
        dto.resumen = libros.resumen;
        break;
       }
    }
   
    }

    //metodo para eliminar

    public void delete(Guid id)
{
    var libroEliminar = this._libros.FirstOrDefault(libros => libros.id == id);

    if (libroEliminar != null)
    {
        this._libros.Remove(libroEliminar);
    }
}

   
}

public class LibrosDTO
{
    public Guid id {get;set;}
    public string titulo {get;set;}
    public string resumen {get;set;}
    public Guid autorId {get;set;}
    
}
