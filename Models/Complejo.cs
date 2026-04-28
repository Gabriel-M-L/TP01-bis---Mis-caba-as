namespace TP1bis_Martinez_Waserman.Models;

public class Complejo{
    private Dictionary<int, Cabana> cabanas;

    public Complejo(){
        cabanas = new Dictionary<int, Cabana>();
        anadirCabanas();
    }

    private void anadirCabanas(){
        cabanas.Add(1, new Cabana(1, "Cabaña del sol.", "Hermosa cabaña a la orilla del mar.", 5, new List<string>(){"bano1.jfif", "cocina1.jfif", "dormitorio1.webp"}, new List<string>(){"Baño espacioso", "Cocina para cocinar", "Dormitorio brillante"}));
        cabanas.Add(2, new Cabana(2, "Cabaña del mar.", "Hermosa cabaña a la orilla del sol.", 2, new List<string>(){"bano2.jpg", "cocina2.jpg", "dormitorio2.jpg"}, new List<string>(){"Baño rapido", "Cocina inteligente", "Dormitorio rapido"}));
        cabanas.Add(3, new Cabana(3, "Cabaña del sol marino.", "Hermosa cabaña debajo del mar.", 50, new List<string>(){"bano3.jfif", "cocina3.jpg", "dormitorio3.webp"}, new List<string>(){"Baño artificialmente intelegente", "Cocina optimisadora de recursos", "Dormitorio artificialmente intelegente"}));
    }

    public Dictionary<int, Cabana> getCabanas(){
        return cabanas;
    }

    public Cabana getCabana(int ID){
        if(cabanas.ContainsKey(ID))
            return cabanas[ID];
        return null;
    }
}