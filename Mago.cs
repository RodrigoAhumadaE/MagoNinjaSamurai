class Mago : Humano{

  // El mago debe tener una salud predeterminada de 50 y una inteligencia de 25.
  public Mago(string nombre) : base(nombre){
    base.Nombre = nombre;
    base.Inteligencia = 25;
    base.Salud = 50;
  }

  /* Proporciona un método de ataque override al Mago, que reduce la salud del objetivo en 3 * Inteligencia
  y cura al Mago por la cantidad de daño infligido. */
  public override int Atacar(Humano humanoAtacado){
    int daño = 3 * Inteligencia;
    humanoAtacado.Salud -= daño;
    base.Salud += daño; 
    return daño;
  }

  // El mago debería tener un método llamado Curación, que cuando se invoca, cura al humano objetivo en 3 * Inteligencia.
  public void Curacion(Humano humanoCurado){
    int valor = 3 * Inteligencia;
    humanoCurado.Salud += valor;
  }
}