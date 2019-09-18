using UnityEngine;
using System.Collections;

public class arraywall2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
     
        GameObject prefab = Resources.Load("Cbrick") as GameObject;
		GameObject prefab2 = Resources.Load("glass") as GameObject;

        GameObject[,] arraywall = new GameObject[10, 10];

        // GameObject brick = Instantiate (prefab) as GameObject;
        
        for (int i = 0; i < 10; i++)
        {
            for (int height = 0; height < 10; height++)
            {
                
                arraywall[i, height] = Instantiate(prefab) as GameObject;

                arraywall [i, height].transform.Rotate(0, 90, 0);

                arraywall[i, height].transform.position = new Vector3
                    (transform.position.x,
                        transform.position.y + height + 0.5f,
                        transform.position.z + i * 2);

            }


        }


        

    }
}