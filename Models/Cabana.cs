namespace TP1bis_Martinez_Waserman.Models;

public class Cabana{
    private int ID;
    private string nombre;
    private string descripcion;
    private int capacidad;
    private List<string> fotos;
    private List<string> ambientes;

    public Cabana(int ID, string nombre, string descripcion, int capacidad, List<string> fotos, List<string> ambientes){
        this.ID = ID;
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.capacidad = capacidad;
        this.fotos = fotos;
        this.ambientes = ambientes;
    }

    public string getNombre(){
        return nombre;
    }
    public string getDescripcion(){
        return descripcion;
    }
    public int getID(){
        return ID;
    }
    public int getCapacidad(){
        return capacidad;
    }

    public List<string> getFotos(){
        return fotos;
    }
    public List<string> getAmbientes(){
        return ambientes;
    }
}