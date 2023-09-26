using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaduraDecorator : Decorator
{
    // Start is called before the first frame update
    void Start()
    {
        vida = 0;
        defensa = 8;
        ataque = 0;

        
    }

    public override int devolverVida(int v)
    {
        int resultado = v += componente.devolverVida(this.vida);
        return resultado;
    }
    public override int devolverAtaque(int v)
    {
        int resultado = v += componente.devolverAtaque(this.ataque);
        return resultado;
    }
    public override int devolverDefensa(int v)
    {
        int resultado = v += componente.devolverDefensa(this.defensa);
        return resultado;
    }

}
