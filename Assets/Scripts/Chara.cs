using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Chara : MonoBehaviour
{
    public int vida;
    public int ataque;
    public int defensa;

    public abstract int devolverVida();
    public abstract int devolverAtaque();
    public abstract int devolverDefensa();


}
