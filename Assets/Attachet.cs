using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attachet : MonoBehaviour
{
    public GameObject Parent;
    
    private void OnTriggerEnter(Collider other) {
        other.transform.SetParent(Parent.transform);
    }


}
