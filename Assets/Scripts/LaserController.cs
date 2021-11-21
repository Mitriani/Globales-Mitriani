using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    [SerializeField] private GameObject rayOrigin;
    [SerializeField] private float velocidad;
    private GameObject player;
    private Vector3 posicionInicial = new Vector3(-0.03f, 1, -9.28f);
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        RayCannon();
        transform.Rotate(Vector3.up, velocidad);
    }

    private void RayCannon()
    {
        RaycastHit hit;

        if(Physics.Raycast(rayOrigin.transform.position, rayOrigin.transform.TransformDirection(Vector3.left), out hit, 10))
        {
            Debug.Log("****** PERDISTE ******");
            player.transform.position = posicionInicial;
            Debug.Log("MUERTES: " + GameManager.muertes++);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(rayOrigin.transform.position, rayOrigin.transform.TransformDirection(Vector3.left) * 10);
    }
}