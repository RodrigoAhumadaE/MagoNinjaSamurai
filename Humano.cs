class Humano{
  public string Nombre { get; set; }
  public int Fuerza { get; set; }
  public int Inteligencia { get; set; }
  public int Destreza { get; set; }
  public int Salud { get; set; }
  public Humano(string nombre){
    Nombre = nombre;
    Fuerza = 3;
    Inteligencia = 3;
    Destreza = 3;
    Salud = 100;
  }  
    
  public Humano(string nombre, int fuerza, int inteligencia, int destreza, int salud)
  {
    Nombre = nombre;
    Fuerza = fuerza;
    Inteligencia = inteligencia;
    Destreza = destreza;
    Salud = salud;
  }

  public virtual int Atacar(Humano humanoAtacado){
    int daño = 3 * Fuerza;
    humanoAtacado.Salud -= daño;
    return daño;
  }

  public void MostrarEstatus(){
    Console.WriteLine("---------------------------");
    Console.WriteLine($"{Nombre}\nFue: {Fuerza}\t\tInt: {Inteligencia}\nDes: {Destreza}\t\tSal: {Salud}");
    Console.WriteLine("---------------------------");
  }
}