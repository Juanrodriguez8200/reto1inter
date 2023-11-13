using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerGameOver : MonoBehaviour
{
    public TMP_Text gameOverText;  // Arrastra el objeto de texto desde la interfaz de usuario al inspector
   

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Enemigo"))
        {
            // Desactivar el jugador
            gameObject.SetActive(false);

            // Mostrar el texto "GAME OVER"
            gameOverText.text = "GAME OVER";
            gameOverText.gameObject.SetActive(true);
              
        }
    }

   
}