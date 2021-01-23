using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridSquare : MonoBehaviour
{
    public int columns = 0;
    public int rows = 0;
    public float sqaure_offset = 0.0f;
    public GameObject grid_sqaure;
    public Vector2 start_position = new Vector2(0.0f, 0.0f);
    public float sqaure_scale = 1.0f;
    public GameObject WinPopUp;
    public GameObject GameOverPopUp;
    public Text textClock;

    private List<GameObject> grid_sqaures_ = new List<GameObject>();

    public int[] data = new int[100];

    private Level1 level1 = new Level1();

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

    void Start()
    {
        WinPopUp.SetActive(false);
        GameOverPopUp.SetActive(false);
        if (grid_sqaure.GetComponent<StarSetting>() == null)
        {
            Debug.LogError("This Game Object need to have GridSqaure script attached !");
        }
        CreateGrid();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreateGrid()
    {
        SpawnGridSqaures();
        SetSqauresPosition();
        SetGridColor(box1, box_1);
        SetGridColor(box2, box_2);
        SetGridColor(box3, box_3);
        SetGridColor(box4, box_4);
        SetGridColor(box5, box_5);
        SetGridColor(box6, box_6);
        SetGridColor(box7, box_7);
        SetGridColor(box8, box_8);
        SetGridColor(box9, box_9);
        SetGridColor(box10, box_10);

    }

    private void SpawnGridSqaures()
    {
        //0, 1, 2, 3, 4, 5, 6,
        //7,8, ....
        int square_index = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                grid_sqaures_.Add(Instantiate(grid_sqaure) as GameObject);
                grid_sqaures_[grid_sqaures_.Count - 1].GetComponent<StarSetting>().SetSquareIndex(square_index);
                grid_sqaures_[grid_sqaures_.Count - 1].transform.parent = this.transform;
                grid_sqaures_[grid_sqaures_.Count - 1].transform.localScale = new Vector3(sqaure_scale, sqaure_scale, sqaure_scale);

                square_index++;
            }
        }
    }

    private void SetSqauresPosition()
    {
        var sqaure_rect = grid_sqaures_[0].GetComponent<RectTransform>();
        Vector2 offset = new Vector2();

        offset.x = sqaure_rect.rect.width * sqaure_rect.transform.localScale.x + sqaure_offset;
        offset.y = sqaure_rect.rect.height * sqaure_rect.transform.localScale.y + sqaure_offset;

        int column_number = 0;
        int row_number = 0;

        foreach (GameObject sqaure in grid_sqaures_)
        {
            if (column_number + 1 > columns)
            {
                row_number++;
                column_number = 0;
            }
            var pos_x_offset = offset.x * column_number;
            var pos_y_offset = offset.y * row_number;
            sqaure.GetComponent<RectTransform>().anchoredPosition = new Vector2(start_position.x + pos_x_offset, start_position.y - pos_y_offset);
            column_number++;
        }
    }

    public void SetSolution()
    {
        int square_index = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                if (!(grid_sqaures_[square_index].GetComponent<StarSetting>().IsEmpty()))
                {
                    data[square_index] = 1;
                }
                else
                    data[square_index] = 0;

                square_index++;
            }
        }
    }

    public void SetGridColor(int[]box,Color box_color)
    {
        for(int i = 0; i < box.Length; i++)
        {
            grid_sqaures_[box[i]].GetComponent<StarSetting>().SetSquareColor(box_color);
        }
    }

    /*public void SetTableColor()
    {
        List<int[]> boxes = level1.GetListBoxes();
        List<Color> box_color = level1.GetListBoxColors();
        SetGridColor(boxes[0], box_color[0]);

    }*/

    public int[] getData()
    {
        return data;
    }

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

    public void Control()
    {
        for (int i = 0; i < 100; i++)
        {
            if (data[i] != realSolution[i])
            {
                GameOverPopUp.SetActive(true);
                textClock.GetComponent<Clock>().SetStopClock(true);

                return;
            }
        }
        WinPopUp.SetActive(true);
        textClock.GetComponent<Clock>().SetStopClock(true);
    }
}
