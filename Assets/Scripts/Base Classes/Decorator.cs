using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator : Chara
{
    
    
    [SerializeField] 
    protected Chara componente;

    public override int devolverVida()
    {
       
        return vida += componente.devolverVida();
    }
    public override int devolverAtaque()
    {
        return ataque += componente.devolverAtaque();
    }
    public override int devolverDefensa()
    {
        return defensa += componente.devolverDefensa();
    }

}
