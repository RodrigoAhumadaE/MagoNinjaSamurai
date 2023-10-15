using System.Diagnostics.Contracts;

Mago mago = new Mago("Roderick");
Console.WriteLine($"Mago {mago.Nombre}\nFuerza: {mago.Fuerza}\tIntel: {mago.Inteligencia}\nDest: {mago.Destreza}\t\tSalud: {mago.Salud}");

Console.WriteLine("--------------------");
Humano enemigo = new Humano("Marius");
Console.WriteLine($"Enemigo {enemigo.Nombre}\nFuerza: {enemigo.Fuerza}\tIntel: {enemigo.Inteligencia}\nDest: {enemigo.Destreza}\t\tSalud: {enemigo.Salud}");
int daño = mago.Atacar(enemigo);
Console.WriteLine("--------------------");
Console.WriteLine($"Mago {mago.Nombre} a atacado a {enemigo.Nombre} con Magia Astral - Daño {daño}");
Console.WriteLine("--------------------");
Console.WriteLine($"Mago {mago.Nombre}\nFuerza: {mago.Fuerza}\tIntel: {mago.Inteligencia}\nDest: {mago.Destreza}\t\tSalud: {mago.Salud}");
Console.WriteLine("--------------------");
Console.WriteLine($"Enemigo {enemigo.Nombre}\nFuerza: {enemigo.Fuerza}\tIntel: {enemigo.Inteligencia}\nDest: {enemigo.Destreza}\t\tSalud: {enemigo.Salud}");

Console.WriteLine("--------------------");
Humano ayudante = new Humano("Tarzis");
Console.WriteLine($"Ayudante {ayudante.Nombre}\nFuerza: {ayudante.Fuerza}\tIntel: {ayudante.Inteligencia}\nDest: {ayudante.Destreza}\t\tSalud: {ayudante.Salud}");
Console.WriteLine("--------------------");
mago.Curacion(ayudante);
Console.WriteLine($"Mago {mago.Nombre} a curado a {ayudante.Nombre} con Magia de Luz");
Console.WriteLine("--------------------");
Console.WriteLine($"Ayudante {ayudante.Nombre}\nFuerza: {ayudante.Fuerza}\tIntel: {ayudante.Inteligencia}\nDest: {ayudante.Destreza}\t\tSalud: {ayudante.Salud}");
Console.WriteLine("--------------------");
Ninja ninja = new Ninja("Hatori");
Console.WriteLine($"Nija {ninja.Nombre}\nFuerza: {ninja.Fuerza}\tIntel: {ninja.Inteligencia}\nDest: {ninja.Destreza}\tSalud: {ninja.Salud}");
Console.WriteLine("--------------------");
Humano enemigo2 = new Humano("Cole");
Console.WriteLine($"Enemigo {enemigo2.Nombre}\nFuerza: {enemigo2.Fuerza}\tIntel: {enemigo2.Inteligencia}\nDest: {enemigo2.Destreza}\t\tSalud: {enemigo2.Salud}");
Console.WriteLine("--------------------");
daño = ninja.Atacar(enemigo2);
Console.WriteLine($"Ninja {ninja.Nombre} a atacado a {enemigo2.Nombre} con ataque Sorpresa - Daño {daño}");
if(daño == 85){
  Console.WriteLine("¡¡Daño Critico!!");
}
Console.WriteLine("--------------------");
Console.WriteLine($"Enemigo {enemigo2.Nombre}\nFuerza: {enemigo2.Fuerza}\tIntel: {enemigo2.Inteligencia}\nDest: {enemigo2.Destreza}\t\tSalud: {enemigo2.Salud}");
Console.WriteLine("--------------------");
ninja.Robar(enemigo2);
Console.WriteLine($"Ninja {ninja.Nombre} a atacado a {enemigo2.Nombre} desde las Sombras");
Console.WriteLine("--------------------");
Console.WriteLine($"Enemigo {enemigo2.Nombre}\nFuerza: {enemigo2.Fuerza}\tIntel: {enemigo2.Inteligencia}\nDest: {enemigo2.Destreza}\t\tSalud: {enemigo2.Salud}");
Console.WriteLine("--------------------");
Console.WriteLine($"Nija {ninja.Nombre}\nFuerza: {ninja.Fuerza}\tIntel: {ninja.Inteligencia}\nDest: {ninja.Destreza}\tSalud: {ninja.Salud}");
Console.WriteLine("--------------------");

Samurai samurai = new Samurai("Musashi");
Console.WriteLine($"Samurai {samurai.Nombre}\nFuerza: {samurai.Fuerza}\tIntel: {samurai.Inteligencia}\nDest: {samurai.Destreza}\t\tSalud: {samurai.Salud}");
Console.WriteLine("--------------------");
Humano enemigo3 = new Humano("Dugt");
Console.WriteLine($"Enemigo {enemigo3.Nombre}\nFuerza: {enemigo3.Fuerza}\tIntel: {enemigo3.Inteligencia}\nDest: {enemigo3.Destreza}\t\tSalud: {enemigo3.Salud}");
Console.WriteLine("--------------------");
daño = samurai.Atacar(enemigo3);
Console.WriteLine($"Samurai {samurai.Nombre} a atacado a {enemigo3.Nombre} con ataque Sorpresa - Daño {daño}");
Console.WriteLine("--------------------");
Console.WriteLine($"Enemigo {enemigo3.Nombre}\nFuerza: {enemigo3.Fuerza}\tIntel: {enemigo3.Inteligencia}\nDest: {enemigo3.Destreza}\t\tSalud: {enemigo3.Salud}");
Console.WriteLine("--------------------");
daño = ninja.Atacar(enemigo3);
Console.WriteLine($"Ninja {ninja.Nombre} a atacado a {enemigo3.Nombre} con ataque Sorpresa - Daño {daño}");
if(daño == 85){
  Console.WriteLine("¡¡Daño Critico!!");
}
Console.WriteLine("--------------------");
Console.WriteLine($"Enemigo {enemigo3.Nombre}\nFuerza: {enemigo3.Fuerza}\tIntel: {enemigo3.Inteligencia}\nDest: {enemigo3.Destreza}\t\tSalud: {enemigo3.Salud}");
Console.WriteLine("--------------------");
daño = samurai.Atacar(enemigo3);
Console.WriteLine($"Samurai {samurai.Nombre} a atacado a {enemigo3.Nombre} con ataque Sorpresa - Daño {daño}");
Console.WriteLine("--------------------");
Console.WriteLine($"Enemigo {enemigo3.Nombre}\nFuerza: {enemigo3.Fuerza}\tIntel: {enemigo3.Inteligencia}\nDest: {enemigo3.Destreza}\t\tSalud: {enemigo3.Salud}");
Console.WriteLine("--------------------");

samurai.Salud-= 115;
Console.WriteLine($"Samurai {samurai.Nombre}\nFuerza: {samurai.Fuerza}\tIntel: {samurai.Inteligencia}\nDest: {samurai.Destreza}\t\tSalud: {samurai.Salud}");
Console.WriteLine("--------------------");
int valor = samurai.Meditacion();
Console.WriteLine($"Samurai {samurai.Nombre} a restaurado {valor} con Meditación");
Console.WriteLine("--------------------");
Console.WriteLine($"Samurai {samurai.Nombre}\nFuerza: {samurai.Fuerza}\tIntel: {samurai.Inteligencia}\nDest: {samurai.Destreza}\t\tSalud: {samurai.Salud}");
Console.WriteLine("--------------------");