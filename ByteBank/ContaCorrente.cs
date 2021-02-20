using ByteBank;

public class ContaCorrente
{
    public static int TotalDeContasCriadas { get; private set; }

    public Cliente Titular { get; set; }
    public int Agencia { get; set; }
    public int Numero { get; set; }
    public double Saldo {get; set;}
    public ContaCorrente(int agencia, int numero)
    {
        Agencia = agencia;
        Numero = numero;

        ContaCorrente.TotalDeContasCriadas++;
    }

    public void DefinirSaldo(double saldo)
    {
        if (saldo < 0)
        {

        }
        else
        {
            this.Saldo = saldo;
        }
    }

    public double ObterSaldo()
    {
        return this.Saldo;
    }

    public bool Sacar(double valor)
    {
        if (this.Saldo < valor)
        {
            return false;
        }

        this.Saldo -= valor;
        return true;

    }

    public void Depositar(double valor)
    {
        this.Saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.Saldo < valor)
        {
            return false;
        }

        this.Saldo -= valor;
        contaDestino.Depositar(valor);
        return true;

    }
}