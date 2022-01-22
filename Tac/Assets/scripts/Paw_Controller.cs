using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Paw_Controller : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (Input.GetKeyUp(KeyCode.Space)) {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
