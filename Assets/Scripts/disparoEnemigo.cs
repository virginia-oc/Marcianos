using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoEnemigo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Nave")
        {
            Debug.Log("Una vida menos");
            Destroy(gameObject);
        }
        else if (other.tag == "LimiteInferior")
            Destroy(gameObject);        
    }
}
