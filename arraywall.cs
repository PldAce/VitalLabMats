 using UnityEngine;
using System.Collections;

public class arraywall : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject prefab = Resources.Load ("rBrick") as GameObject;
		GameObject prefab2 = Resources.Load ("gBrick") as GameObject;

		GameObject [,] arraywall = new GameObject[5, 5];

		// GameObject brick = Instantiate (prefab) as GameObject;

		for (int i = 0; i < 5; i++) 
		{
			for (int height = 0; height < 5; height++) 
			{
				if ((i == 0 && height == 0) || (i == 1 && height == 1) || (i == 2 && height == 2)
				    || (i == 3 && height == 3) || (i == 4 && height == 4) || (i == 5 && height == 5))
				{
                    arraywall[i, height] = Instantiate(prefab2) as GameObject;
				

                    arraywall[i, height].transform.position = new Vector3
                        (transform.position.x + i * 2,
                            transform.position.y + height + 0.5f,
                            transform.position.z);
				}
				 else 
				{
					arraywall[i, height] = Instantiate(prefab) as GameObject;
					
					
					arraywall[i, height].transform.position = new Vector3
						(transform.position.x + i * 2,
						 transform.position.y + height + 0.5f,
						 transform.position.z);
					}

			}
		}




	}
}