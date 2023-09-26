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

        txtpro.GetComponent<TextMeshProUGUI>().text = "Vida: " + mainchara.devolverVida().ToString() + "Ataque: " + mainchara.devolverAtaque().ToString() + "Defensa: " + mainchara.devolverDefensa().ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
