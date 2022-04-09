using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grid : MonoBehaviour
{
    public int col, row;
    void Update()
    {
        RectTransform parent = GetComponent<RectTransform>();
        GridLayoutGroup grid = GetComponent<GridLayoutGroup>();

        grid.cellSize = new Vector2(parent.rect.width/col,parent.rect.height/row);
    }

   
}
