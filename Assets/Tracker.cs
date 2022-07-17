using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracker : MonoBehaviour
{

    public enum EventType
    {
        LateUpdate,
        Update,
        FixUpdate
    }



    public Transform TrackTarget;
    public EventType Methodtype = EventType.Update;
    public float Speed;


    private void LateUpdate() {
        if (Methodtype == EventType.LateUpdate)
        {
            transform.position = Vector3.Slerp(transform.position,TrackTarget.position,Time.deltaTime*Speed);
        }
    }


    private void Update() {
        if (Methodtype == EventType.Update)
        {
            transform.position = Vector3.Slerp(transform.position,TrackTarget.position,Time.deltaTime*Speed);
        }
    }


    private void FixedUpdate() {
        if (Methodtype == EventType.FixUpdate)
        {
            transform.position = Vector3.Slerp(transform.position,TrackTarget.position,Time.deltaTime*Speed);
        }
    }



}
