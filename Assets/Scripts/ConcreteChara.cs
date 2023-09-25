using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteChara : Chara
{

    public override int vida = 10;
    public override int ataque = 15;
    public override int defensa = 5;


    public override int devolverVida()
    {
        return vida;
    }
    public override int devolverAtaque()
    {
        return ataque;
    }
    public override int devolverDefensa()
    {
        return defensa;
    }
}
