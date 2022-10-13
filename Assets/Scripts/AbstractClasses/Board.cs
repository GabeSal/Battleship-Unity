using System;
using UnityEngine;

public abstract class Board : MonoBehaviour, IBoard
{
    /* Board cell indices
     * 
     * 00, 01, 02, 03, 04, 05, 06, 07, 08, 09
     * 10, 11, 12, 13, 14, 15, 16, 17, 18, 19
     * 20, 21, 22, 23, 24, 25, 26, 27, 28, 29
     * 30, 31, 32, 33, 34, 35, 36, 37, 38, 39
     * 40, 41, 42, 43, 44, 45, 46, 47, 48, 49
     * 50, 51, 52, 53, 54, 55, 56, 57, 58, 59
     * 60, 61, 62, 63, 64, 65, 66, 67, 68, 69
     * 70, 71, 72, 73, 74, 75, 76, 77, 78, 79
     * 80, 81, 82, 83, 84, 85, 86, 87, 88, 89
     * 90, 91, 92, 93, 94, 95, 96, 97, 98, 99
     */
    protected GameObject[,] _cells;
    public event Action<IBoard> OnBoardSwap;

    /// <summary>
    /// Sets the length of each index in the 2D _cells array
    /// </summary>
    /// <param name="firstLength">Int value for the length of the first index</param>
    /// <param name="secondLength">Int value for the length of the second index</param>
    public void SetDimensionsCellArray(int firstLength, int secondLength)
    {
        _cells = new GameObject[firstLength, secondLength];
    }

    /// <summary>
    /// Public method that stores a reference of an instantiated cell for the EnemyBoard.
    /// </summary>
    /// <param name="i">Int value for the first index of the 2D _cells array</param>
    /// <param name="j">Int value for the second index of the 2D _cells array</param>
    /// <param name="newCell">The GameObject object to store in 2D _cells array</param>
    public void AllocateCells(int i, int j, GameObject newCell)
    {
        _cells[i, j] = newCell;
    }

    /// <summary>
    /// Returns a Vector3 that will position an instantiated cell prefab in the PopulateBoard method
    /// </summary>
    /// <param name="i">Current row index in the 2D _cells array</param>
    /// <param name="j">Current column index in the 2D _cells array</param>
    /// <returns></returns>
    public Vector3 SetCellPosition(int i, int j)
    {
        return new Vector3(-7.75f + (1.5f * i), 0f, 7.0f - (1.5f * j));
    }
}
