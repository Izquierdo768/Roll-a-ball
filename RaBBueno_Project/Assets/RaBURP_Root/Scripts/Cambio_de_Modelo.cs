using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambio_de_Modelo : MonoBehaviour
{
    public GameObject[] modelList;
    public int modelRandomNumber;

    // Start is called before the first frame update
    void Start()
    {
        modelRandomNumber = Random.Range(1, 4);

        if (modelRandomNumber == 1)
        {
            modelList[0].gameObject.SetActive(true);
        }
        if (modelRandomNumber == 2)
        {
            modelList[1].gameObject.SetActive(true);
        }
        if (modelRandomNumber == 3)
        {
            modelList[2].gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
