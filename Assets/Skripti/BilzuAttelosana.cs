using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BilzuAttelosana : MonoBehaviour
{
    public GameObject head;
    public GameObject body;
    public GameObject legs;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;

    public void mainitLielumu(){
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        mainigaisAttels.transform.localScale = new Vector3(1F * pasreizejaVertiba, 1F * pasreizejaVertiba, 1);
    }

    public void izkritosais(int skaitlis)
    {
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];
        }
        else if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];
        }
    
    }

    public void galvuAttelosana(bool vertiba)
    {
        head.SetActive(vertiba);
    }

    public void bodyAttelosana(bool vertiba)
    {
        body.SetActive(vertiba);
    }

    public void kajuAttelosana(bool vertiba)
    {
        legs.SetActive(vertiba);
    }
}
