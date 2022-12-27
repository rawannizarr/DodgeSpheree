using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Rigidbody rb;
    float force = 10;

    public GameObject target;
    

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void Update()
    {
        //Add a forward force
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.M))

        {
            Debug.Log("m");
            ResetKinematic();
            rb.AddForce(0, 0, sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log("n");
            ResetKinematic();
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }
    }

    void ResetKinematic()
    {
        rb.isKinematic = true;
        rb.isKinematic = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ball"))
        {
            Vector3 dir = target.transform.position - transform.position;
            Vector3 vector3 = dir.normalized * force;
            other.GetComponent<Rigidbody>().velocity = vector3;
        }
    }
}