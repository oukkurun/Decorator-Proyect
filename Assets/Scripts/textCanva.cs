using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textCanva : MonoBehaviour
{
    public GameObject txtpro;
    public Chara mainchara;
    public GameObject txtpro2;
    public Chara mainchara2;
    public GameObject txtpro3;
    public Chara mainchara3;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        txtpro.GetComponent<TextMeshProUGUI>().text = "Vida: " + mainchara.devolverVida(0) + " Ataque: " + mainchara.devolverAtaque(0) + " Defensa: " + mainchara.devolverDefensa(0);
        txtpro2.GetComponent<TextMeshProUGUI>().text = "Vida: " + mainchara2.devolverVida(0) + " Ataque: " + mainchara2.devolverAtaque(0) + " Defensa: " + mainchara2.devolverDefensa(0);
        txtpro3.GetComponent<TextMeshProUGUI>().text = "Vida: " + mainchara3.devolverVida(0) + " Ataque: " + mainchara3.devolverAtaque(0) + " Defensa: " + mainchara3.devolverDefensa(0);
    }
}
