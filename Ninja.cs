class Ninja : Humano {
  // Ninja debería tener una destreza predeterminada de 75
  public Ninja(string nombre) : base(nombre){
    base.Nombre = nombre;
    base.Destreza = 75;
  }

  /* Proporciona un método de ataque overrida al Ninja, que reduce la salud del objetivo
  en su cantidad de Destreza y tiene un 20 % de posibilidades de infligir 10 puntos de daño adicionales. */
  public override int Atacar(Humano humanoAtacado){
    Random rand = new Random();
    int x = rand.Next(5);
    int daño = Destreza;
    if(x == 4){
      daño+=10;
    }
    humanoAtacado.Salud -= daño;
    return daño;
  }

  /* Ninja debería tener un método llamado Robar, reduce la salud del humano objetivo en 5 y agrega esta cantidad a su propia salud. */
  public void Robar(Humano humanoAtacado){
    humanoAtacado.Salud -= 5;
    base.Salud += 5;
  }
}