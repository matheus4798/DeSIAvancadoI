class Program{
    public static void main(string[] args){
        Pessoa objPessoa = new Pessoa("Matheus");
        Conso.WriteLine("Antes do método (Classe):") + objPessoa.ToString()
    }

    public static void AlteraNomeClasse(Pessoa objAux){
        objAux.Nome = "Danielly";
    }
}