using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetPixel : MonoBehaviour
{
    public RawImage pic;
    public TextMeshProUGUI tex_mouse = null;
    public TextMeshProUGUI tex2_color = null;


    void Update()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        int pos1 = (int)mousePosition.x;
        int pos2 = (int)mousePosition.y;
        Color32 color = (pic.texture as Texture2D).GetPixel(pos1, pos2);
        tex_mouse.text = "x = " + pos1 + " | " + "y = " + pos2;
        tex2_color.text = color.ToString();
    }
}
