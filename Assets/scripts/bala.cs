using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{

    void start()
    {

    }

    void Update()
    {
       transform.Translate(Vector3.right * Time.deltaTime * -10);   
       StartCoroutine(Damage());
    }
    IEnumerator Damage()
    {
    yield return new WaitForSeconds(10f);

       Destroy(gameObject);

    }


     private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (collision.CompareTag("Player"))
            {
                Application.LoadLevel(Application.loadedLevel);

            }
        }
    }
}
