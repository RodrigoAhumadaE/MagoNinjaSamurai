using System.Diagnostics.Contracts;

Mago mago = new Mago("Roderick");
Console.WriteLine($"Creado Personaje Mago {mago.Nombre}");
mago.MostrarEstatus();

Humano enemigo = new Humano("Marius");
Console.WriteLine($"Creado Enemigo {enemigo.Nombre}");
enemigo.MostrarEstatus();

int daño = mago.Atacar(enemigo);
Console.WriteLine($"Mago {mago.Nombre} a atacado a {enemigo.Nombre} con Magia Astral - Daño {daño}");
enemigo.MostrarEstatus();
Console.WriteLine($"Mago {mago.Nombre} a restaurado {daño} de Salud con habilidad extra de Magia Astral");
mago.MostrarEstatus();

Humano ayudante = new Humano("Tarzis");
Console.WriteLine($"Creado Ayudante {ayudante.Nombre}");
mago.Curacion(ayudante);
Console.WriteLine("---------------------------");
Console.WriteLine($"Mago {mago.Nombre} a curado a {ayudante.Nombre} con Magia de Luz");
ayudante.MostrarEstatus();
Ninja ninja = new Ninja("Hatori");
Console.WriteLine($"Creado Personaje Ninja {ninja.Nombre}");
ninja.MostrarEstatus();

Humano enemigo2 = new Humano("Cole");
Console.WriteLine($"Creado Enemigo {enemigo2.Nombre}");
enemigo2.MostrarEstatus();
daño = ninja.Atacar(enemigo2);
Console.WriteLine($"Ninja {ninja.Nombre} a atacado a {enemigo2.Nombre} con ataque Sorpresa - Daño {daño}");
if(daño == 85){
  Console.WriteLine("¡¡Daño Critico!!");
}
enemigo2.MostrarEstatus();
ninja.Robar(enemigo2);
Console.WriteLine($"Ninja {ninja.Nombre} a atacado a {enemigo2.Nombre} desde las Sombras - Daño 5");
enemigo2.MostrarEstatus();
Console.WriteLine($"Ninja {ninja.Nombre} a restaurado 5 de Salud con habilidad extra de ataque desde las Sombras");
ninja.MostrarEstatus();

Samurai samurai = new Samurai("Musashi");
Console.WriteLine($"Creado Personaje Samurai {samurai.Nombre}");
samurai.MostrarEstatus();
Humano enemigo3 = new Humano("Dugt");
Console.WriteLine($"Creado Enemigo {enemigo3.Nombre}");
enemigo3.MostrarEstatus();
daño = samurai.Atacar(enemigo3);
Console.WriteLine($"Samurai {samurai.Nombre} a atacado a {enemigo3.Nombre} con ataque Espadas Dobles - Daño {daño}");
enemigo3.MostrarEstatus();
daño = ninja.Atacar(enemigo3);
Console.WriteLine($"Ninja {ninja.Nombre} a atacado a {enemigo3.Nombre} con ataque Sorpresa - Daño {daño}");
if(daño == 85){
  Console.WriteLine("¡¡Daño Critico!!");
}
Console.WriteLine("---------------------------");

daño = samurai.Atacar(enemigo3);
Console.WriteLine($"Samurai {samurai.Nombre} a atacado a {enemigo3.Nombre} con ataque Espadas Dobles - Daño {daño}");
enemigo3.MostrarEstatus();

samurai.Salud-= 115;
Console.WriteLine($"Samurai {samurai.Nombre} recibe 115 de daño");
samurai.MostrarEstatus();
int valor = samurai.Meditacion();
Console.WriteLine($"Samurai {samurai.Nombre} a restaurado {valor} con Meditación");
samurai.MostrarEstatus();