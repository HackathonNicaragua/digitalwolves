﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryBookUIElement : MonoBehaviour
{

    [Tooltip("El titulo del storybook")] public string StoryBookTitle;
    [Tooltip("La imagen (textura) que tendra el storybook en el menu")] public Texture StoryBookTexture;

    [Header("Imagenes y texto")]
    public Text StoryText;
    public RawImage StoryCoverImage;

    private void Start()
    {
        StoryText.text = StoryBookTitle;
        StoryCoverImage.texture = StoryBookTexture;
    }
}
