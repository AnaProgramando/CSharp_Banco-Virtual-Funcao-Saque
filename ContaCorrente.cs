public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numConta;
    // Valor padrão do saldo inicial da conta é de 100 e não 0
    public double saldo = 100;


    public bool Sacar(double valor)
    {
        if(this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }
}
