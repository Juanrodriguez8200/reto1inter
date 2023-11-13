using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class PANELES : MonoBehaviour
{


    public GameObject panelGanar;
    public GameObject panelPerder;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Enemigo"))
        {

            panelPerder.SetActive(true);

            Time.timeScale = 0;

        }

        if (collision.gameObject.CompareTag("Caliz"))
        {

            panelGanar.SetActive(true);


            Time.timeScale = 0 ;

        }

    

    }
    private void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.CompareTag("Enemigo"))

        {
            panelPerder.SetActive(true);

        }


    }

}
