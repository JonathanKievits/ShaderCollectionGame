using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{

    private Hungry hungry;
    
    void Start()
    {
        hungry = GetComponent<Hungry>();
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "food")
        {
            hungry.Amount += 0.01f;
            Destroy(coll.gameObject);
        }
    }
}
