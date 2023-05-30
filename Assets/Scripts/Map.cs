using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map<T>
{
    public int Width = 10;
    public int Height = 10;
    public List<T> map = new List<T>();


    public Map(int width, int height, T defaultValue)
    {
        Width = width;
        Height = height;
        for (int i = 0; i < Width * Height; i++)
        {
            map.Add(defaultValue);
        }
    }

    public T GetCell(int x, int y)
    {
        return map[ y * Width + x ];
    }

    public T GetIndex(int index)
    {
        return map[index];
    }

    public Vector2Int GetCoord(int index)
    {
        int x = index % Width;
        int y = Mathf.FloorToInt(index / Width);
        return new Vector2Int(x, y);
    }
}
