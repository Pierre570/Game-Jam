using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedGauge : MonoBehaviour
{
    public Image Gauge;
    public Sprite[] sprites;
    void Update()
    {
        Gauge.sprite = sprites[PlayerInfo.DummySpeed - 1];
    }
}
