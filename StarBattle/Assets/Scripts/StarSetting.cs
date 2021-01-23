using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class StarSetting : Selectable, IPointerClickHandler
{
    public GameObject black_star;
    private bool active_black;
    private bool empty;
    int square_index_ = -1;

    public bool IsBlackActive()
    {
        return active_black==true;
    }

    public bool IsEmpty()
    {
        return empty == true;
    }

    void Start()
    {
        empty = true;
    }

    public void SetColorBlack()
    {
        black_star.SetActive(true);
        active_black = true;
        empty = false;
    }

    public void SetEmpty()
    {
        black_star.SetActive(false);
        active_black = false;
        empty = true;
    }

    public void SetSquareIndex(int index)
    {
        square_index_ = index;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (IsEmpty())
        {
            SetColorBlack();
        }
        else
            SetEmpty();
    }

    public void SetSquareColor(Color col)
    {
        var colors = this.colors;
        colors.normalColor = col;
        colors.selectedColor = col;
        this.colors = colors;
    }


}
