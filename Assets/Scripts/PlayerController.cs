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
        moveX = Input.GetAxis("Horizontal");
        moveY = Input.GetAxis("Vertical");

        transform.position += speed * Time.deltaTime * new Vector3(moveX, moveY, 0).normalized;
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x,-22,22),
            Mathf.Clamp(transform.position.y,-13,0),
            0
            );

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(pfBullet, shotPoint.position, Quaternion.identity);
        }
    }
}
