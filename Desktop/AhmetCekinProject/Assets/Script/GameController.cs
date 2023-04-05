using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.ComponentModel.Design.Serialization;

public class GameController : MonoBehaviour
{
    public List<GameObject> prefabObjects = new List<GameObject>();

    private static System.Random rng = new System.Random();
    public List<int> posCount = new List<int>();
    public List<TextMeshProUGUI> textMesh = new List<TextMeshProUGUI>();
    public List<GameObject> PrefabObjectsVertical = new List<GameObject>();
    public int countss;
    public int test;
    public GameObject parentObject;
    public int count;
    public static GameController Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        Randomize();
        InfoTextVertical();

    }
    private void Update()
    {
        if (count < 4)
        {
            InfoTextVertical();

        }
    }

    public void Randomize()
    {
        int n = prefabObjects.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            var value = prefabObjects[k];
            prefabObjects[k] = prefabObjects[n];
            prefabObjects[n] = value;
        }
        for (int i = 0; i < prefabObjects.Count; i++)
        {
            prefabObjects[i].transform.parent = parentObject.transform;
            PrefabObjectsVertical.Add(prefabObjects[i]);
        }

    }

    public void InfoTextVertical()
    {
        count++;
        for (int i = 0; i < 4; i++)
        {
            test += prefabObjects[i].GetComponent<Value>().valueCount;
        }


        textMesh[0].text = test.ToString();
        textMesh.Remove(textMesh[0]);
        test = 0;
        for (int i = 0; i < 3; i++)
        {
            prefabObjects.Remove(prefabObjects[i]);
        }
        countsHorizontal();

    }

    public void countsHorizontal()
    {
        countss = int.Parse(PrefabObjectsVertical[0].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[4].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[8].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[12].GetComponent<Value>().valueCount.ToString());
        textMesh[0].text = countss.ToString();
        countss = 0;
        countss = int.Parse(PrefabObjectsVertical[1].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[5].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[9].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[13].GetComponent<Value>().valueCount.ToString());
        textMesh[1].text = countss.ToString();
        countss = 0;
        countss = int.Parse(PrefabObjectsVertical[2].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[6].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[10].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[14].GetComponent<Value>().valueCount.ToString());
        textMesh[2].text = countss.ToString();
        countss = 0;
        countss = int.Parse(PrefabObjectsVertical[3].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[7].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[11].GetComponent<Value>().valueCount.ToString()) + int.Parse(PrefabObjectsVertical[15].GetComponent<Value>().valueCount.ToString());
        textMesh[3].text = countss.ToString();
    }

}
