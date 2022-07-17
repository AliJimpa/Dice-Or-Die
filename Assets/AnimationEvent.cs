using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent : MonoBehaviour
{
    private void DetachAll(string tag)
    {
        foreach (Transform child in transform)
        {
            if (child.tag == tag)
            {
                child.transform.parent = null;
                print(child.name);
            }
        }
    }

    private void DiactiveBoxCollide(string target)
    {
        GameObject.Find(target).GetComponent<BoxCollider>().enabled = false;
    }

    private void ActiveBoxCollide(string target)
    {
       GameObject.Find(target).GetComponent<BoxCollider>().enabled = true;
    }
}
