using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator : Chara
{
    
    
    [SerializeField] 
    protected Chara componente;

    public override int devolverVida(int v)
    {
       
        return v += componente.devolverVida(vida);
    }
    public override int devolverAtaque(int v)
    {
        return v += componente.devolverAtaque(ataque);
    }
    public override int devolverDefensa(int v)
    {
        return v += componente.devolverDefensa(defensa);
    }

}
