Console.Write("Digite o valor do salário-hora (R$): ");
decimal salarioHora = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o total de horas trabalhadas: ");
decimal horasTrabalhadas = Convert.ToDecimal(Console.ReadLine());

Console.Write("Digite o número de horas extras: ");
decimal horasExtras = Convert.ToDecimal(Console.ReadLine());

decimal salarioFinal = CalcularSalario(salarioHora, horasTrabalhadas, horasExtras);

Console.WriteLine();
Console.WriteLine($"Salário total a receber: R$ {salarioFinal:F2}");

decimal CalcularSalario(decimal valorHora, decimal horasNormais, decimal horasExtras)
{
    decimal salarioBase = valorHora * horasNormais;
    decimal valorHoraExtra = valorHora * 1.4m; 
    decimal salarioExtras = valorHoraExtra * horasExtras;

    return salarioBase + salarioExtras;
}
