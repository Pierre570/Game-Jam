using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImage : MonoBehaviour
{
    private int imageCount = 0;
    public SpriteRenderer introSprite;
    public Sprite[] sprites;

    public void ChangeSprite()
    {
        if (imageCount == 11)
            PlayerInfo.ChangeScene("Menu");
        else {
            introSprite.sprite = sprites[imageCount];
            imageCount += 1;
        }
    }
}
