using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    public int carSpeed;
    public int minSpeed = 20;
    public int maxSpeed = 120;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RadarDeVelocidad();
        AnularVelocidadNegativa();
    }

    void RadarDeVelocidad()
    {
        //Definición de condicional
        if (carSpeed > maxSpeed)
        {
            Debug.Log("Te estás pasando de velocidad!");
        }
        else if (carSpeed < minSpeed)
        {
            Debug.Log("Vas demasiado lento, aprieta el acelerador!");
        }
        else
        {
            Debug.Log("Vas a la velocidad correcta!");
        }
    }

    void AnularVelocidadNegativa()
    {
        if (carSpeed < 0) { carSpeed = 0; }
    }
}
