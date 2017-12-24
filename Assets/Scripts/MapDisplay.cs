﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{

    public Renderer texturerRenderer;

    public void DrawTexture(Texture2D texture)
    {
        texturerRenderer.sharedMaterial.mainTexture = texture;
        texturerRenderer.transform.localScale = new Vector3(texture.width, 1, texture.height);
    }
}
