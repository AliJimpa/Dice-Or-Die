using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public KeyCode Rollingdice;
    public GameObject Bowl;



    Animation _anmation;


    private void Awake() {
        _anmation = Bowl.GetComponent<Animation>();
    }



    private void Update() {

        if (Input.GetKeyDown(Rollingdice))
        {
            _anmation.Play("Roll");
        }


    }
}
