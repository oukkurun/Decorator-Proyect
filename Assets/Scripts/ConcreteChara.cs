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

        Debug.Log("Ataque Chara: " + devolverAtaque(ataque).ToString());
    }


    public override int devolverVida(int v)
    {
        return vida += v;
    }
    public override int devolverAtaque(int v)
    {
        return ataque += v;
    }
    public override int devolverDefensa(int v)
    {
        return defensa += v;
    }
}
