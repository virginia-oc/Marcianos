using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    [SerializeField] float velocidad = 2;
    [SerializeField] Transform prefabDisparo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        transform.Translate(horizontal * velocidad * Time.deltaTime, 0, 0);
        //Debug.Log(Time.deltaTime + "seg, " + (1.0f / Time.deltaTime) + "FPS");

        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(prefabDisparo, transform.position, Quaternion.identity);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Golpeado");
    }
}
