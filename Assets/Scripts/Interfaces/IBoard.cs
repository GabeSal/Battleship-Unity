using System;
using UnityEngine;

public interface IBoard
{
    public event Action<IBoard> OnBoardSwap;

    public void SetDimensionsCellArray(int firstLength, int secondLength);
}
