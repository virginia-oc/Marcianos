using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    [SerializeField] float velocidad = 4;
    [SerializeField] Transform prefabDisparo;
    private float velocidadDisparo = 4;
    [SerializeField] TMPro.TextMeshProUGUI texto;
    private int vidas = 3;

    // Start is called before the first frame update
    void Start()
    {
        texto.text = "Vidas restantes: " + vidas;
    }

    // Update is called once per frame
    void Update()
    {   
        float horizontal = Input.GetAxisRaw("Horizontal");
        float deltaX = horizontal * velocidad * Time.deltaTime;

        if (transform.position.x + deltaX > -4 
            && transform.position.x + deltaX < 4)
        {
            transform.Translate(deltaX, 0, 0);
        }
        //Debug.Log(Time.deltaTime + "seg, " + (1.0f / Time.deltaTime) + "FPS");
        

        if (Input.GetButtonDown("Jump"))
        {
            GetComponent<AudioSource>().Play();
            Transform disparo = 
                Instantiate(prefabDisparo, transform.position, 
                Quaternion.identity);
            disparo.gameObject.GetComponent<Rigidbody2D>().velocity =
                new Vector3(0, velocidadDisparo, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        texto.text = "Vidas restantes: " + vidas--;
    }
}
