using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Chara : MonoBehaviour
{
    [SerializeField] protected int vida;
    [SerializeField] protected int defensa;
    [SerializeField] protected int ataque;

    public abstract int devolverVida();
    public abstract int devolverAtaque();
    public abstract int devolverDefensa();


}
