using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speedX;
    public float speedY;
    public float speedZ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    void Rotation()
    {
        transform.Rotate(Vector3.right * speedX * Time.deltaTime);
        transform.Rotate(Vector3.up * speedY * Time.deltaTime);
        transform.Rotate(Vector3.forward * speedZ * Time.deltaTime);
    }

}
