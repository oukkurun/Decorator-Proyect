using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class textCanva : MonoBehaviour
{
    public GameObject txtpro;
    public Chara mainchara;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        txtpro.GetComponent<TextMeshProUGUI>().text = "Vida: " + mainchara.devolverVida(0) + "Ataque: " + mainchara.devolverAtaque(0) + "Defensa: " + mainchara.devolverDefensa(0);
    }
}
