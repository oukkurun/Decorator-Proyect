using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textCanva : MonoBehaviour
{
    public Text text;
    public Chara mainchara;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Vida: " + mainchara.devolverVida() + "Ataque: " + mainchara.devolverAtaque() + "Defensa: " + mainchara.devolverDefensa();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
