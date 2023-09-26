using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollarDecorator : Decorator
{
    // Start is called before the first frame update
    void Start()
    {
        vida = 7;
        defensa = 0;
        ataque = 2;

        Debug.Log("Ataque Collar: " + devolverAtaque(ataque).ToString());


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
