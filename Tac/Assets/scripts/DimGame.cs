using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DimGame : MonoBehaviour
{
    public Image image;

    void Update()
    {
        if (PlayerInfo.enhealth < 100) {
            image = GetComponent<Image>();
            var tempColor = image.color;
            tempColor.a = PlayerInfo.enhealth / 255;
            image.color = tempColor;
        }
    }
}
