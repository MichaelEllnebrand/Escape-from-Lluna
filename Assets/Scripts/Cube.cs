using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float xRotation;
    [SerializeField] private float yRotation;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(xRotation * Time.deltaTime, yRotation * Time.deltaTime, 0f);


    }
}
