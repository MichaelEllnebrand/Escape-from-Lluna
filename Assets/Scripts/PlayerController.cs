using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform pfBullet;
    [SerializeField] private Transform shotPoint;

    [SerializeField] private float speed;

    private float moveX;
    private float moveY;


    void Update()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");

        transform.position += speed * Time.deltaTime * new Vector3(moveX, moveY, 0).normalized; 

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(pfBullet, shotPoint.position, Quaternion.identity);
        }
    }
}
