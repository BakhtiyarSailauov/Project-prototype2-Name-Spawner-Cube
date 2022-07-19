using UnityEngine;
using System.Collections;

public class CupeSpawner2 : MonoBehaviour
{
    public GameObject cubePrefabVar;
    void Start()
    {
        //Instantiate(cubePrefabVar);
    }

    // Update is called once per frame
    void Update()
    {
        SpellItOut();
        Instantiate(cubePrefabVar);
    }
      
    public void SpellItOut()
    {
        string sA = "Hello World!";
        string sB = "";

        for (int i = 0; i < sA.Length; i++)
        {
            sB += sA[i];
        }
        print(sB);
    }
}
