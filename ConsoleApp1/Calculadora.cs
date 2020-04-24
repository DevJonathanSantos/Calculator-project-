namespace ConsoleApp1
{
    public class Calculadora
    {
        public Operacao Operacao { get; set; }
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
        public int Resultado { get; private set; }

        public int Somar()
        {
            this.Executar(Operacao.Somar, this.Valor1, this.Valor2);

            return this.Resultado;
        }
        public int Subtrair()
        {
            this.Executar(Operacao.Subtrair, this.Valor1, this.Valor2);

            return this.Resultado;

        }
        public int dividir()
        {
            this.Executar(Operacao.Dividir, this.Valor1, this.Valor2);
            return this.Resultado;
        }
        public int multiplicar()
        {
            this.Executar(Operacao.Multiplicar, this.Valor1, this.Valor2);
            return this.Resultado;
        }
        public void Executar(Operacao operacao, int valor1, int valor2)
        {
            this.Operacao = operacao;
            this.Valor1 = valor1;
            this.Valor2 = valor2;

            this.Executar();
        }

        public void Executar()
        {
            switch (this.Operacao)
            {
                case Operacao.Somar:
                    {
                        this.Resultado = this.Valor1 + this.Valor2;
                        break;
                    }
                case Operacao.Subtrair:
                    {
                        this.Resultado = this.Valor1 - this.Valor2;
                        break;
                    }
                case Operacao.Dividir:
                    {
                        this.Resultado = this.Valor1 / this.Valor2;
                        break;
                    }
                case Operacao.Multiplicar:
                    {
                        this.Resultado = this.Valor1 * this.Valor2;
                        break;
                    }
            }
        }
    }
}
