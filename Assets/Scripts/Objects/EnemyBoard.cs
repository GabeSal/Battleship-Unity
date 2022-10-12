using System;
using UnityEngine;

public class EnemyBoard : MonoBehaviour, IBoard
{
    [SerializeField]
    private GameObject[,] _cells;
    [SerializeField]
    private int _boardDimensionX;
    [SerializeField]
    private int _boardDimensionY;
    public event Action<IBoard> OnBoardSwap;

    public void GenerateBoard(int dimX, int dimY)
    {
        _boardDimensionX = dimX;
        _boardDimensionY = dimY;

        _cells = new GameObject[_boardDimensionX, _boardDimensionY];
    }

}
