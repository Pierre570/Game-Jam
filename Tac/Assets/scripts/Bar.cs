using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public GameObject bar;
    public Vector2 base_position;
    void Start()
    {
        bar.transform.position = base_position;
    }
}
