using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ConcreteChara : Chara
{

    private void Start()
    {
        vida = 10;
        defensa = 10;
        ataque = 10;
    }


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
