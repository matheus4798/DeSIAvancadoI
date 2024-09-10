public class Cliente
{
    private int id;
    private string nome;
    
    public int Id{
        get{return id;}
        set{id = value;}
    }

    public string Nome{
        get{return nome;}
        set{nome = value;}
    }

    public Cliente(int id, string nome){
        Id = id;
        Nome = nome;
    }
    public override string ToString(){
        return $"id:{id}, Nome:{Nome}";
    }

}