using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Event dropped;
    public Event pickup;
    public Image icon;
    void Start()
    {
        dropped.Occured(this.gameObject);
    }


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pickup.Occured(this.gameObject);
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(this.gameObject, 5f);
        }
    }
}
