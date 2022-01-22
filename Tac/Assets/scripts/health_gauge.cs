using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_gauge : MonoBehaviour
{
    public GameObject Target;
    public Slider SliderDis;
    public Vector3 base_position;

    public void Start()
    {
        base_position = Target.transform.position;
        SliderDis.maxValue = PlayerInfo.enemy_max_health;
    }
    void Update()
    {
        SliderDis.value = PlayerInfo.enhealth;
        Target.transform.position = new Vector3(base_position.x + SliderDis.value * 2, base_position.y);
    }
}