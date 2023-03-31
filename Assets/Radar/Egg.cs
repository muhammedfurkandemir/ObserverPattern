using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Event dropped;
    public Image icon;
    void Start()
    {
        dropped.Occured(this.gameObject);
    }

    
    void Update()
    {
        
    }
}
