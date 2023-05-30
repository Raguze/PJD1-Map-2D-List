using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public Map<GameObject> Map;

    void Start()
    {
        Map = new Map<GameObject>(3, 3, new GameObject());
    }

    
    void Update()
    {
        Map.GetCell(1, 2);
    }
}
