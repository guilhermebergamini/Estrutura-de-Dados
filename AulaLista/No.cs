public class No{

    public int valor;

    public No prox; //ponteiro ou apontador para o prox nó
    //construtor
    public No(int Valor){
        this.valor = Valor;
        this.prox = null;
    }

    public void Imprimir(){
        Console.WriteLine("Valor: " + this.valor);
    }
}
