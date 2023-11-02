namespace entregabletres.Entreble;

public class AutoresHandler
{
    private List<AutoresDTO> _autores;

    public AutoresHandler(List<AutoresDTO> autores)
    {
         this._autores = autores;
   }

   public List<AutoresDTO> All(){
    return this._autores;
   }

   //metodo para crear
   public void create(AutoresDTO autores)
   {
    this._autores.Add(autores);
   }

   //metodo para actualizar
   public void update(AutoresDTO autores,Guid id)
   {
    var autoresE = this._autores.FirstOrDefault(autores => autores.id == id);
 
    foreach (AutoresDTO dto in this._autores)
    {
       if (dto.id == id){
        dto.nombre = autores.nombre;
        dto.nacionalidad = autores.nacionalidad;
        break;
       }
    }
   
    }

    //metodo para eliminar

    public void delete(Guid id)
{
    var AutorEliminar = this._autores.FirstOrDefault(autores => autores.id == id);

    if (AutorEliminar != null)
    {
        this._autores.Remove(AutorEliminar);
    }
}

   
}

public class AutoresDTO


{
    public Guid id {get;set;}
    public string nombre {get;set;}
    public string nacionalidad {get;set;}
}
