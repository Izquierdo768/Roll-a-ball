using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramacionBase : MonoBehaviour
{
    //Variables primitivas
    public int edadPersona = 33;
    public float altura = 1.64f;
    public string nombre = "Jorge";
    public bool llevaGafas = true;

    //Variables compuestas
    public Vector3 posicion = new Vector3(2, 3.5f, 4.2f);
    public Vector2 posicion2d = new Vector2(15, 30);

    //Variables de referencia
    public Rigidbody miRigidbody;
    public Transform miTransform;
    public BoxCollider miCollider;

    //Variables para ejemplos varios
    int vidaPersonaje = 100;
    int manaPersonaje = 5000;
    public bool esCara;

    //Variables en estructura Array
    public int[] arrayNumeros = new int[5] {5, 10, 15, 20, 25};
    public int[] estanteriaLibros = new int[6];
    public string[] grupoDeAnimales;

    //Tipos de métodos
    //Métodos de llamada (salen en color azul)
    private void Start()
    {
        //Lo que ocurre aquí dentro se ejecuta 1 vez, en el primer frame del juego
        Debug.Log("Hola Jorge! Soy el Start");
        Debug.Log(edadPersona);
        SumaSimple();
        EscanearEstadistica(vidaPersonaje);
        EscanearEstadistica(manaPersonaje);
        CaraOCruz();
        Debug.Log(grupoDeAnimales[2]);
        grupoDeAnimales[3] = "Jirafa";
    }

    private void Update()
    {
        //Lo que ocurre aquí se ejecuta 1 vez por frame de juego (constante)
        Debug.Log("Te estoy saludando desde el Update");
    }

    //Método sin tipo de dato = Acciones generales
    void SumaSimple() 
    {
        int numeroA = 4;
        int numeroB = 6;
        int sumaTotal;

        sumaTotal = numeroA + numeroB + edadPersona;
        Debug.Log(sumaTotal);
    
    }
    //Método sin tipo de dato, con variable referencia = Acción que usa una valor flexible
    void EscanearEstadistica(int estadistica)
    {
        Debug.Log(estadistica + " tienes tanto de ese stat!");
    }

    //Método con tipo de dato = Acción que almacena un valor de X tipo en la memoria del ordenador
    bool CaraOCruz()
    {
        Debug.Log(esCara);
        return esCara;
    }

}



