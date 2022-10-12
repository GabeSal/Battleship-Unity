using System;
using UnityEngine;

public interface IBoard
{
    public event Action<IBoard> OnBoardSwap;
}
