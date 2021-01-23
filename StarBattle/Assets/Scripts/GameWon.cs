using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWon : MonoBehaviour
{
    public int[] realSolution = new int[100]{
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
        int[] data = new int[100];
        data=GetComponent<GridSquare>().getData();
        for(int i = 0; i < 100; i++)
        {
            if (data[i] != realSolution[i])
            {
                Debug.Log("amk");
                break;
            }
        }
        Debug.Log("tebrikler");
    }
}
