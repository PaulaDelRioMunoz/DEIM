using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasEnemy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        //Mira hacia la cámara de la escena que tenga la etiqueta "MainCamera"
        transform.LookAt(Camera.main.transform.position);
        
    }
}
