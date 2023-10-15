class Samurai : Humano{
  // Samurai debería tener una salud predeterminada de 200
  public Samurai(string nombre) : base(nombre){
    base.Nombre = nombre;
    base.Salud = 200;
  }

  /* Proporcionar un método de ataque overrode a Samurai, que invoca el ataque base y reduce la salud del
  objetivo a 0 si le quedan menos de 50 puntos de vida. */
  public override int Atacar(Humano humanoAtacado){
    int daño;
    if(humanoAtacado.Salud < 50){
      daño = humanoAtacado.Salud;
      humanoAtacado.Salud = 0;
      return daño;
    }
    daño = base.Atacar(humanoAtacado);
    return daño;
  }

  /* Los samuráis deberían tener un método llamado Meditación, que cuando se invoca, cura al samurái hasta que recupera su salud completa. */
  public int Meditacion(){
    int restauracion = 200 - base.Salud;
    base.Salud += restauracion;
    return restauracion;
  }
}