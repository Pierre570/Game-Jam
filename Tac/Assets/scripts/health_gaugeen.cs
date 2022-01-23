using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health_gaugeen : MonoBehaviour
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
        Target.transform.position = new Vector3(base_position.x - SliderDis.value * 2.3f, base_position.y);
        if (PlayerInfo.enhealth >= PlayerInfo.enemy_max_health) {
            PlayerInfo.ChangeScene("Menu");
            PlayerInfo.health = 0;
            PlayerInfo.enhealth = 0;
            PlayerInfo.level1Cleared = true;
        }
    }
}