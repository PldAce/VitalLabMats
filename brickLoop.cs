using UnityEngine;
using System.Collections;

public class brickLoop : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject prefab = Resources.Load ("LoopBrick") as GameObject;

		// GameObject brick = Instantiate (prefab) as GameObject;

		for (int i = 0; i < 10; i++) 
		{
            for (int height = 0; height < 10; height++)
            {

                
                  
                GameObject brick = Instantiate(prefab) as GameObject;

                brick.transform.position = new Vector3
                            (transform.position.x + i * 2,
                            transform.position.y + height + 0.5f,
                                transform.position.z);
                
		
			}
		}
			
	
	}
}
