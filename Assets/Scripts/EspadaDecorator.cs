using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspadaDecorator : Decorator
{
    // Start is called before the first frame update
    void Start()
    {
        vida = 0;
        defensa = 0;
        ataque = 15;

        Debug.Log("Ataque Espada : " + devolverAtaque(ataque).ToString());
    }

    public override int devolverVida(int v)
    {
        int resultado = v += componente.devolverVida(vida);
        return resultado;
    }
    public override int devolverAtaque(int v)
    {
        int resultado = v += componente.devolverVida(ataque);
        return resultado;
    }
    public override int devolverDefensa(int v)
    {
        int resultado = v += componente.devolverVida(defensa);
        return resultado;
    }
}

