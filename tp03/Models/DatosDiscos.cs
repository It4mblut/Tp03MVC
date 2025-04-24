namespace tp03.Models;

public class DatosDiscos
{
    //El sistema debe permitir almacenar un catálogo de discos. 
    //Que cada disco esté asociado a un artista, un productor, un género musical, una lista de Temas,  
    //además de un id que los identifique y una foto.
    public string nombre {get; private set;}
    public string artista {get; private set;}
    public string productor {get; private set;}
    public string generoMusical {get; private set;}
    public List<string> temas;

    public DatosDiscos(string nombre, string artista, string productor, string generoMusical, List<string> temas){
        this.nombre=nombre;
        this.artista=artista;
        this.productor=productor;
        this.generoMusical=generoMusical;
        this.temas=temas;
    }



}