using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{

    private void Start()
    {
        Debug.Log("item pick up start");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collision");
        if (other.gameObject.name == "PlayerCol")
        {
            Destroy(this.transform.parent.gameObject);
            Debug.Log("Item Collected");
        }
    }
}
