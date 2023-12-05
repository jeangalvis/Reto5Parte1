
Console.Write("Ingresa el SamDaily: ");
int samDaily = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingresa el KellyDaily: ");
int kellyDaily = Convert.ToInt32(Console.ReadLine());
Console.Write("Ingresa el Difference: ");
int difference = Convert.ToInt32(Console.ReadLine());


int validador = 0;
int contador = 0;
int samsolved = 0;
int kellysolved = 0;
while (validador !=1){
    if(samDaily >= kellyDaily){
        contador = -1;
        validador = 1;
    }
    contador ++;
    if(contador == 1){
        samsolved = samDaily + difference;
        kellysolved = kellyDaily;
    }
    else{
        samsolved += samDaily;
        kellysolved += kellyDaily;
    }
    if(kellysolved> samsolved){
        validador = 1;
    }
}

Console.WriteLine(contador);