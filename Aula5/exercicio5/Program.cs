const int HORAS_TREINAMENTO = 1000;

Console.WriteLine("-----------============= Bem-vindo ao Treinamento Jedi =============----------------");

Console.WriteLine("Quantas horas por dia você irá treinar?");
double horas_diarias = double.Parse(Console.ReadLine());

double horas_semanais = horas_diarias*5;

double total_dias = HORAS_TREINAMENTO/horas_diarias;

double total_semanas = total_dias/5;

double total_meses = total_semanas/4.5;

double meses = total_meses-(total_meses-(int)total_meses);

double semanas = (total_meses-(int)total_meses)*4.5;

double dias = (semanas-(int)semanas)*5;

semanas = semanas-(semanas-(int)semanas);


if(meses<0.00001)
meses = 0;

if (semanas<0.00001)
semanas = 0;

if(dias>0.00001)
dias = dias-(dias-(int)dias) +1;
else
dias = 0;

Console.Write($"Você precisará de {meses} meses");

if(semanas!=0){

   if(dias ==0)
    Console.Write($" e {semanas} semanas ");

    else
    Console.Write($", {semanas} semanas e {dias} dias ");
}

Console.WriteLine($"para completar o treinamento Jedi treinando {horas_semanais} horas por semana.");








