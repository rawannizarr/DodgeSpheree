using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    Vector3 intialposition = new Vector3();
    private void Start()
    {
        intialposition = transform.position;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("wall"))
        {
            transform.position = intialposition;

        }
        if (other.gameObject.CompareTag("Win"))
        {
            Debug.Log("You Win");
            Time.timeScale = 0;
        }
    }
}
