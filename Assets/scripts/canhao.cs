using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canhao : MonoBehaviour
{
    public GameObject tiro;
    public bool atira;
    
    
    void Update()
    {
        if(atira == true)
        StartCoroutine(TimerDestroy());

    }

    public IEnumerator TimerDestroy()
    {
        Instantiate(tiro, transform.position, transform.rotation);
        atira = false;
        yield return new WaitForSeconds(1);
        atira = true;
    }
}
