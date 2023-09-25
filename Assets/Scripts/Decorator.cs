using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator : Chara
{
    
    
    [SerializeField] 
    protected Chara componente;

    public Decorator(Chara componente)
    {
        this.componente = componente;
    }

    public void SetComponent(Chara componente)
    {
        this.componente = componente;
    }

    public override int devolverVida()
    {
       
        return componente.devolverVida();
    }
    public override int devolverAtaque()
    {
        return componente.devolverAtaque();
    }
    public override int devolverDefensa()
    {
        return componente.devolverDefensa();
    }

}
