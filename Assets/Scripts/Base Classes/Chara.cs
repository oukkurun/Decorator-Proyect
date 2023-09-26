using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Chara : MonoBehaviour
{
    protected int vida;
    protected int defensa;
    protected int ataque;

    public abstract int devolverVida(int vidaASumar);
    public abstract int devolverAtaque(int ataqueASumar);
    public abstract int devolverDefensa(int defensaASumar);


}
