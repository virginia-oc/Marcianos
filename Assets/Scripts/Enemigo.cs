using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    private static float velX = 2;
    private static float velY = 1;
    [SerializeField] Transform prefabDisparoEnemigo;
    private float velocidadDisparo = -4;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Disparar());
    }

    IEnumerator Disparar()
    {
        float pausa = Random.Range(1.0f, 11.0f);
        yield return new WaitForSeconds(pausa);

        Transform disparo = Instantiate(prefabDisparoEnemigo, 
            transform.position, Quaternion.identity);

        Physics2D.IgnoreCollision(
            disparo.GetComponent<Collider2D>(), GetComponent<Collider2D>());

        disparo.gameObject.GetComponent<Rigidbody2D>().velocity =
            new Vector3(0, velocidadDisparo, 0);

        StartCoroutine(Disparar());
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
