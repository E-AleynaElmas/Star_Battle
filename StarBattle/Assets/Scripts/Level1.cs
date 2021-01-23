using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level1 : MonoBehaviour
{
    private int[] box1 = { 0, 1, 2, 10, 20, 21, 22, 30, 40, 50, 60, 61 };
    public Color box_1;
    private int[] box2 = { 3, 4, 14, 24, 34 };
    public Color box_2;
    private int[] box3 = { 5, 6, 7, 8, 9, 16, 18, 26 };
    public Color box_3;
    private int[] box4 = { 11, 12, 13, 23, 31, 32, 33, 41, 41, 51, 52, 53 };
    public Color box_4;
    private int[] box5 = { 15, 17, 25, 27, 35, 36, 37, 47, 57 };
    public Color box_5;
    private int[] box6 = { 19, 28, 29, 38, 39, 49, 59, 69, 79, 86, 89, 96, 97, 98, 99 };
    public Color box_6;
    private int[] box7 = { 42, 43, 44, 54, 62, 63, 64, 72, 82, 83, 84 };
    public Color box_7;
    private int[] box8 = { 45, 55, 65, 73, 74, 75, 76, 77, 87 };
    public Color box_8;
    private int[] box9 = { 46, 48, 56, 58, 66, 67, 68, 78, 88 };
    public Color box_9;
    private int[] box10 = { 70, 71, 80, 81, 85, 90, 91, 92, 93, 94, 95 };
    public Color box_10;

    private List<int[]> boxes = new List<int[]>();
    private List<Color> box_colors = new List<Color>();

    private int[] realSolution = new int[100]{
          0, 0, 0, 0, 0, 0, 1, 0, 0, 1,
          0, 0, 1, 0, 1, 0, 0, 0, 0, 0,
          1, 0, 0, 0, 0, 0, 0, 1, 0, 0,
          0, 0, 1, 0, 1, 0, 0, 0, 0, 0,
          0, 0, 0, 0, 0, 0, 0, 1, 0, 1,
          1, 0, 0, 0, 0, 1, 0, 0, 0, 0,
          0, 0, 0, 1, 0, 0, 0, 0, 1, 0,
          0, 1, 0, 0, 0, 1, 0, 0, 0, 0,
          0, 0, 0, 1, 0, 0, 0, 0, 1, 0,
          1, 0, 0, 0, 0, 0, 1, 0, 0, 0

    };

    public List<int[]> GetListBoxes()
    {
        boxes.Add(box1);
        boxes.Add(box2);
        boxes.Add(box3);
        boxes.Add(box4);
        boxes.Add(box5);
        boxes.Add(box6);
        boxes.Add(box7);
        boxes.Add(box8);
        boxes.Add(box9);
        boxes.Add(box10);
        return boxes;
    }


    public List<Color> GetListBoxColors()
    {
        box_colors.Add(box_1);
        box_colors.Add(box_2);
        box_colors.Add(box_3);
        box_colors.Add(box_4);
        box_colors.Add(box_5);
        box_colors.Add(box_6);
        box_colors.Add(box_7);
        box_colors.Add(box_8);
        box_colors.Add(box_9);
        box_colors.Add(box_10);

        return box_colors;
    }

    public int[] GetRealSolution()
    {
        return realSolution;
    }
    
}
