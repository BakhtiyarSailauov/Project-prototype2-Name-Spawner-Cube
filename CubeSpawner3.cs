using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner3 : MonoBehaviour
{
    public GameObject cubePrefabVar;
    public List<GameObject> gameObjectList;
    public float scalingFactor = 0.95f;
    public int allCubesValue = 0;
    void Start()
    {
        gameObjectList = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        allCubesValue++;
        GameObject gObjct = Instantiate<GameObject>(cubePrefabVar);
        gObjct.name += "Cube " + allCubesValue;
        Color c = new Color(Random.value, Random.value, Random.value);
        gObjct.GetComponent<Renderer>().material.color = c;
        gObjct.transform.position = Random.insideUnitSphere;
        gameObjectList.Add(gObjct);

        List<GameObject> removeList = new List<GameObject>();

        foreach (var goTemp in gameObjectList)
        {
            float scale = goTemp.transform.localScale.x;
            scale *= scalingFactor;
            goTemp.transform.localScale =Vector3.one *  scale;
            if (scale <= 0.1f)
            { removeList.Add(goTemp); }
        }
       foreach (var item in removeList)
        {
            gameObjectList.Remove(item);
            Destroy(item);
        }
    }
}
