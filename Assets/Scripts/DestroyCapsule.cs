using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCapsule : MonoBehaviour
{

    public bool capsuleCol = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)

    {


        {

            if (collision.gameObject.CompareTag("Player"))
            {
                Destroy(gameObject);
                capsuleCol = true;

            }

        }

    }

}
