namespace calculadora
{
    public class Calculadora
    {

        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public decimal Resultado { get; set; }


        public Calculadora(decimal numero1, decimal numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public void Sumar()
        {
            Resultado = Numero1 + Numero2;
        }

        public void Restar()
        {
            Resultado = Numero1 - Numero2;
        }

        public void Multiplicar()
        {
            Resultado = Numero1 * Numero2;
        }


        public void Dividir()
        {
            if (Numero2 != 0)
            {
                Resultado = Numero1 / Numero2;
            }
            else
            {
                throw new ArgumentException("No se puede dividir por cero.");
            }
        }
    }
}