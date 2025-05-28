// See https://aka.ms/new-console-template for more information


int manae = 92;
double manae_terrestre = 0.651 * manae;


//population de zbol qui augmente de 500000 par manae
int pop_zbol = 10000000;
int nouvelle_pop_zbol(int pop_zbol, int manae)
{
    pop_zbol = pop_zbol + 500000 * manae;
    return pop_zbol;
}


//population de tamn qui augmente de 3% par manae
int pop_tamn = 5000000;
double nouvelle_pop_tamn(double pop_tamn, int manae)
{
    for (int i = 0; i < manae; i++)
    {
        pop_tamn = pop_tamn * 1.03;
    }
    return pop_tamn;
}

//determine dans combien de manae la population de tamn dépassera celle de zbol
int comparaison_population_apres_X_manae(double pop_tamn, int pop_zbol)
{
    int manae = 0;
    while (pop_tamn <= pop_zbol)
    {
        manae++;
        pop_zbol = nouvelle_pop_zbol(pop_zbol, manae);
        pop_tamn = nouvelle_pop_tamn(pop_tamn, manae);
        
    }
    return manae;
}

Console.WriteLine($"Population Zbol après {manae} manae : {nouvelle_pop_zbol(pop_zbol, manae)}");
Console.WriteLine($"Population Tamn après {manae} manae : {nouvelle_pop_tamn(pop_tamn, manae)}");
Console.WriteLine($"Nombre de manae nécessaires pour que la population de tamn dépasse celle de zbol : {comparaison_population_apres_X_manae(pop_tamn, pop_zbol)}");
