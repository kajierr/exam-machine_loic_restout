// See https://aka.ms/new-console-template for more information

int manae = 2;
double manae_terrestre = 0.651 * manae;

int pop_zbol = 10000000;
int pop_tamn = 5000000;

int nouvelle_pop_zbol(int pop_zbol, int manae)
{
    pop_zbol = pop_zbol + 500000 * manae;
    return 0;
}

double nouvelle_pop_tamn(double pop_tamn, int manae)
{
    pop_tamn = pop_tamn + (0.03 * pop_tamn * manae);
    return 0;
}


Console.WriteLine($"Population Zbol après {manae} manae : {pop_zbol}");
Console.WriteLine($"Population Tamn après {manae} manae : {pop_tamn}");
