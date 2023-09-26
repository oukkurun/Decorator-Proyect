using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmaduraDecorator : Decorator
{
    // Start is called before the first frame update
    void Start()
    {
        vida = 0;
        defensa = 8;
        ataque = 0;

        Debug.Log("Ataque Armadura: " + devolverAtaque(ataque).ToString());
    }

    
}
