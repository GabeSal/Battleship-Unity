using System;
using UnityEngine;

public abstract class Board : MonoBehaviour
{
    [SerializeField]
    protected Transform[] _cells;
    public event Action<Board> OnBoardSwap;
}
