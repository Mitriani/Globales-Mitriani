using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rbPlayer;
    private float speed = 9;
    private bool isDead = false;
    private float contador = 0;
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float hMov = Input.GetAxis("Horizontal");
        float VMov = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(hMov, 0, VMov) * speed * Time.deltaTime);
    }
}
