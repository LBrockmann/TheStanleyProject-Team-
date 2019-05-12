using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureRandomizer : MonoBehaviour

{
    public Sprite[] pictures;
    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = pictures[Random.Range(0, pictures.Length)];
    }
}
