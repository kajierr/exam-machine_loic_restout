using System;

// population de zbol qui augmente de 500000 par manae
int pop_zbol = 10000000;
int nouvelle_pop_zbol(int pop_zbol, int manae)
{
    return pop_zbol + 500000 * manae;
}

// population de tamn qui augmente de 3% par manae
int pop_tamn = 5000000;
double nouvelle_pop_tamn(double pop_tamn, int manae)
{
    for (int i = 0; i < manae; i++)
    {
        pop_tamn = pop_tamn * 1.03;
    }
    return pop_tamn;
}

// détermine dans combien de manae la population de tamn dépassera celle de zbol
int comparaison_population_apres_X_manae(double pop_tamn, int pop_zbol)
{
    int manae = 0;
    double pop_tamn_actuel = pop_tamn;
    int pop_zbol_actuel = pop_zbol;

    while (pop_tamn_actuel <= pop_zbol_actuel)
    {
        manae++;
        pop_zbol_actuel = nouvelle_pop_zbol(pop_zbol, manae);
        pop_tamn_actuel = nouvelle_pop_tamn(pop_tamn, manae);
    }
    return manae;
}

int manae = comparaison_population_apres_X_manae(pop_tamn, pop_zbol);
double manae_terrestre = 0.651 * manae;

Console.WriteLine($"Population Zbol après {manae} manae : {nouvelle_pop_zbol(pop_zbol, manae)}");
Console.WriteLine($"Population Tamn après {manae} manae : {nouvelle_pop_tamn(pop_tamn, manae)}");
Console.WriteLine($"Nombre de manae nécessaires pour que la population de tamn dépasse celle de zbol : {manae} soit {manae_terrestre} année terrestre.");
