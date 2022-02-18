public class Empresa   //Nome da classe
{
    
    private string _nome;           //atributo
    private string _telefone;       //atributo
    private int _noFuncionarios;    //atributo

    public string Nome              //propriedade
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public string Telefone          //propriedade
    {
        get { return _telefone; }
        set { _telefone = value; }
    }

    public int InserirNoFuncionarios(int noFuncionarios) => _noFuncionarios = noFuncionarios; //metodo
    public int ObterNoFuncionarios() => return _noFuncionarios;                               //metodo
}



