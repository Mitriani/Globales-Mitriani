using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject vida1, vida2, vida3;
    [SerializeField] private GameObject player;
    void Start()
    {
        
    }

    void Update()
    {
        Vida();
    }

    public void PlayButton()
    {
        Debug.Log("VIDAS RESTANTES: " + GameManager.vidas);
        Debug.Log("Empieza el juego.");
        menuPanel.SetActive(!menuPanel.activeSelf);
    }

    public void Vida()
    {
        vida1.gameObject.SetActive(true);
        vida2.gameObject.SetActive(true);
        vida3.gameObject.SetActive(true);

        if (GameManager.vidas == 2)
        {
            vida3.gameObject.SetActive(false);
            vida2.gameObject.SetActive(true);
            vida1.gameObject.SetActive(true);
        }
        if (GameManager.vidas == 1)
        {
            vida3.gameObject.SetActive(false);
            vida2.gameObject.SetActive(false);
            vida1.gameObject.SetActive(true);
        }
        if (GameManager.vidas == 0)
        {
            vida3.gameObject.SetActive(false);
            vida2.gameObject.SetActive(false);
            vida1.gameObject.SetActive(false);

            Destroy(player.gameObject);

            Debug.Log("PERDISTE!");
        }
    }
}
