using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private static float velX = 2;
    private static float velY = 1;
    [SerializeField] Transform disparoEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velX * Time.deltaTime, velY * Time.deltaTime, 0);

        velX = transform.position.x < -4 || 
            transform.position.x > 4 ? velX * -1 : velX;
        velY = transform.position.y < -2.5 || 
            transform.position.y > 2.5 ? velY * -1 : velY;
    }
}
