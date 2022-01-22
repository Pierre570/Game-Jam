using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovePaw : MonoBehaviour
{
    public GameObject Target;
    public Slider SliderDis;

    public void Start()
    {
        SliderDis.maxValue = PlayerInfo.player_max_health;
    }
    void Update()
    {
        SliderDis.value = PlayerInfo.health;
        Target.transform.position += new Vector3(SliderDis.value, 0.0f, 0.0f);
    }
}
