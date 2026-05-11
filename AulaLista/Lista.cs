public class Lista
{
    public No inicio;
    public No fim;

    public Lista()
    {
        this.inicio = null;
        this.fim = null;
    }

    public bool estaVazia()
    {
        return inicio == null && fim == null;
    }

    public void inserirInicio(int Valor)
    {
        No novoNo = new No(Valor);

        if (this.estaVazia())
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            novoNo.prox = this.inicio;
            this.inicio = novoNo;
        }
    }

    public void InserirFim(int Valor)
    {
        No novoNo = new No(Valor);

        if (this.estaVazia())
        {
            this.inicio = novoNo;
            this.fim = novoNo;
        }
        else
        {
            this.fim.prox = novoNo;
            this.fim = novoNo;
        }
    }

    public void Percurso()
    {
        No noAtual = this.inicio;

        while (noAtual != null)
        {
            Console.Write(noAtual.valor + " -> ");
            noAtual = noAtual.prox;
        }

        Console.WriteLine("null");
    }

    public bool buscar(int chave)
    {
        No noAtual = this.inicio;

        while (noAtual != null)
        {
            if (noAtual.valor == chave)
            {
                return true;
            }

            noAtual = noAtual.prox;
        }

        return false;
    }

    public void RemoverInicio()
    {
        if (this.estaVazia())
        {
            Console.WriteLine("Necessário inserir valores na lista.");
        }
        else
        {
            int valorRemovido = this.inicio.valor;

            this.inicio = this.inicio.prox;

            if (this.inicio == null)
            {
                this.fim = null;
            }

            Console.WriteLine("Removendo o elemento do início: " + valorRemovido);
        }
    }

    public void RemoverFim()
    {
        if (this.estaVazia())
        {
            Console.WriteLine("Necessário inserir valores na lista.");
        }
        else if (this.inicio == this.fim)
        {
            int valorRemovido = this.fim.valor;

            this.inicio = null;
            this.fim = null;

            Console.WriteLine("Removendo o elemento do fim: " + valorRemovido);
        }
        else
        {
            No noAtual = this.inicio;

            while (noAtual.prox != this.fim)
            {
                noAtual = noAtual.prox;
            }

            int valorRemovido = this.fim.valor;

            noAtual.prox = null;
            this.fim = noAtual;

            Console.WriteLine("Removendo o elemento do fim: " + valorRemovido);
        }
    }

    public void RemoverMeio()
    {
        if (this.estaVazia())
        {
            Console.WriteLine("Necessário inserir valores na lista.");
        }
        else if ()
    }
}