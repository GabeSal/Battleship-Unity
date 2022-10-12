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

        PopulateBoard();
    }

    private void PopulateBoard()
    {
        GameObject cellInstance = Resources.Load("Prefabs/Cell", typeof(GameObject)) as GameObject;

        for (int i = 0; i < _boardDimensionX; i++)
        {
            for (int j = 0; j < _boardDimensionY; j++)
            {
                GameObject newCell = Instantiate(cellInstance, SetCellPosition(i, j), Quaternion.identity, this.transform);
                _cells[i, j] = newCell;
            }
        }
    }

    private Vector3 SetCellPosition(int i, int j)
    {
        return new Vector3(-7.75f + (1.5f * i), 0f, 7.0f - (1.5f * j));
    }
}
