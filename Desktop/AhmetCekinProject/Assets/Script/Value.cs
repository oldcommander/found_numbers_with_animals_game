using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Value : MonoBehaviour
{
    public int valueCount;
    private void Awake()
    {
        valueCount = Random.Range(1, 4);
    }
   
}
