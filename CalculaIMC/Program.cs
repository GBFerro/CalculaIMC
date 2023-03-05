internal class Program
{
    private static void Main(string[] args)
    {
        float altura, peso, imc;
        char sexo;

        Console.WriteLine("Digite sua altura (m): ");
        altura = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu peso (kg): ");
        peso = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite seu genero (M/F): ");
        sexo = char.Parse(Console.ReadLine());

        imc = (peso / (altura * altura));
        Console.WriteLine(imc);

        if (sexo == 'M')
        {
            if (imc < 20.7)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc <= 26.4)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (imc <= 27.8)
            {
                Console.WriteLine("Levemente acima do peso ideal");
            }
            else if (imc <= 31.1)
            {
                Console.WriteLine("Acima do peso ideal");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }
        }
        else
        {
            if (imc < 19.1)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc <= 25.8)
            {
                Console.WriteLine("Peso ideal");
            }
            else if (imc <= 27.3)
            {
                Console.WriteLine("Levemente acima do peso ideal");
            }
            else if (imc <= 32.3)
            {
                Console.WriteLine("Acima do peso ideal");
            }
            else
            {
                Console.WriteLine("Obesidade");
            }
        }
    }
}