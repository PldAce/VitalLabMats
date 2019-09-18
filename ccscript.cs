using UnityEngine;
using System.Collections;

public class ccscript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

        GameObject prefab = Resources.Load("ccbrick") as GameObject;
        GameObject prefab2 = Resources.Load("glass") as GameObject;

        GameObject[,] arraywall = new GameObject[11, 11];

        // GameObject brick = Instantiate (prefab) as GameObject;

        for (int i = 0; i < 11; i++)
        {
            for (int height = 0; height < 11; height++)
            {
               
                    arraywall[i, height] = Instantiate(prefab) as GameObject;


                arraywall[i, height].transform.position = new Vector3
                    (transform.position.x + i * prefab.transform.localScale.x,
                         transform.position.y + height * prefab.transform.localScale.y + 0.5f,
                         transform.position.z);
                

            }
        }




    }
}