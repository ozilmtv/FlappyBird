using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pantillatodos : MonoBehaviour
{
    private float spriteWidth;
    int elemenRepat = 5;

    private void Start()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        spriteWidth = sprite.texture.width / sprite.pixelsPerUnit;
    }
    private void Update()
    {
        if (transform.position.x < -spriteWidth * elemenRepat)
        {
            ResetPosition();
        }
    }
    private void ResetPosition()
    {
        transform.Translate(new Vector3(2 * elemenRepat * spriteWidth, 0f, 0f));
    }
}
