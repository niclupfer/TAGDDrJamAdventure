using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : MonoBehaviour
{
	public GameObject[] objs;

	public float forestWidth;
	public float cellSize;
	public float spawnChance;
	
    void Start()
	{
		BuildForest ();
	}



	void BuildForest()
    {
		var pos = new Vector3(-forestWidth * 0.5f, 0, -forestWidth * 0.5f);

		int rows = Mathf.FloorToInt (forestWidth / cellSize);
		for(int x = 0; x < rows; x++)
		{
			for (int y = 0; y < rows; y++) {
				var n = Random.value;
				if (n < spawnChance) {

					int o = Mathf.FloorToInt(Random.Range (0, objs.Length));
					var newObj = Instantiate (objs [o]);
					newObj.transform.parent = transform;
					newObj.transform.localPosition = pos + new Vector3 (x * cellSize, 0, y * cellSize);					
				}
			}
		}
    }
}
