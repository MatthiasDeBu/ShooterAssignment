using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    
    public GameObject explosionParticle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "projectile")
        {
            print("hit");
            print(transform.position);
            Instantiate(explosionParticle, transform.position, transform.rotation);

            

            Destroy(gameObject);
        }
    }
}
