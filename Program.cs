// variáveis usadas
double valor = 0;
double valor_final =0;
int cont_carros = 0;
int cont_motos = 0;
int veiculos_mais_2h = 0;

System.Console.WriteLine("quantos veiculos foram atendidos no dia: ");
int veiculos_dia = int.Parse(Console.ReadLine());

// laço para repetir com base na quantidade de veículos do dia
for(int i = 0; i < veiculos_dia ;i++ ){
    System.Console.WriteLine("selecione o tipo de veiculo, digite 1 para carro, ou 2 para moto: ");
    int tipo_veiculo = int.Parse(Console.ReadLine());


    System.Console.WriteLine("------------------------------------------------------------------");
    System.Console.WriteLine("digite a quantidade de horas que o veiculo permaneceu no estacionamento: ");
    int horas_estacionamento = int.Parse(Console.ReadLine());


    if(tipo_veiculo == 1 && horas_estacionamento <= 2)
    {
        valor = 15;
        valor_final = valor_final + valor;
        cont_carros++;
        Console.WriteLine("Valor a pagar: R$ " + valor);
    }
    else if (tipo_veiculo == 1 && horas_estacionamento > 2)
    {
        valor = 15 + (5*(horas_estacionamento-2));
        valor_final = valor_final + valor;
        cont_carros++;
        veiculos_mais_2h++;
        Console.WriteLine("Valor a pagar: R$ " + valor);
    }

    else if(tipo_veiculo == 2 && horas_estacionamento <= 2)
    {
        valor = 8;
        valor_final = valor_final + valor;
        cont_motos ++;
        Console.WriteLine("Valor a pagar: R$ " + valor);
    }
    else if (tipo_veiculo == 2 && horas_estacionamento > 2)
    {
        valor = 8 + (3*(horas_estacionamento-2));
        valor_final = valor_final + valor;
        cont_motos ++;
        veiculos_mais_2h++;
        Console.WriteLine("Valor a pagar: R$ " + valor);
    }
    else
    {
        System.Console.WriteLine("opção invalida");
    }

}
//resultado
System.Console.WriteLine("----------------------------------------------");
System.Console.WriteLine("o total de veiculos atendidos no dia foi de: "+ veiculos_dia);
System.Console.WriteLine("a quantidade total de carros atendidos no dia foram de: "+ cont_carros);
System.Console.WriteLine("a quantidade total de motos atendidos no dia foram de: "+ cont_motos);
System.Console.WriteLine("o valor total arrecadado no dia foi de: R$ " + valor_final);
System.Console.WriteLine("a quantidade de veiculos que ficaram mais de 2 horas foram de: "+veiculos_mais_2h);
System.Console.WriteLine("----------------------------------------------");