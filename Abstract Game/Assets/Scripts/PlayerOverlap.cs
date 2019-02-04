using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOverlap : MonoBehaviour
{
    public RenderTexture renderTexture;
    public SpriteRenderer spriteRenderer;
    Texture2D texture;

    public float scale = 1;

    void Start()
    {
        texture = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);
    }

    void Update()
    {
        SetSprite();

        // transform.localScale = new Vector3(scale, scale, scale);
    }


    public void SetSprite(){

        RenderTexture.active = renderTexture;
        Texture2D tex = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);
        tex.filterMode = FilterMode.Point;
        tex.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
        tex.Apply();


        for(int i = 0; i < renderTexture.width; i++)
        {
            for(int j = 0; j < renderTexture.height;j++)
            {
                if(tex.GetPixel(i,j).r > 0.0f && tex.GetPixel(i,j).b < 1f)
                {
                    texture.SetPixel(i,j, new Color(0,0,0) );
                }
            }
        }
        texture.Apply();

        Sprite sprite = Sprite.Create(texture, new Rect(0, 0, renderTexture.width, renderTexture.height), new Vector2(0.5f, 0.5f), renderTexture.width);
        spriteRenderer.sprite = sprite;
    }
}
