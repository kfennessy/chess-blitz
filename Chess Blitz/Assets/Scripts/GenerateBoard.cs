using UnityEngine;
using System.Collections;

public class GenerateBoard : MonoBehaviour {

    public GameObject prefab;
    public int width;
    public int height;

	// Use this for initialization
	void Start () {

        for (int z = 0; z < height; z++)
        {

            for (int x = 0; x < width; x++)
            {
                GameObject test = (GameObject)Instantiate(prefab, new Vector3(x * 1.0f, 0, z), Quaternion.identity);
                Renderer rend = test.GetComponent<Renderer>();

                bool alternate = false;
                if (z % 2 == 0)
                {
                    alternate = true;

                }

                if (x % 2 == 0)
                {
                    if (alternate)
                        rend.material.color = new Color(0, 0, 0);
                    else
                        rend.material.color = new Color(1, 1, 1);
                }
                else
                {
                    if (!alternate)
                        rend.material.color = new Color(0, 0, 0);
                    else
                        rend.material.color = new Color(1, 1, 1);
                }
            }
        }
      }
	
	// Update is called once per frame
	void Update () {
	
	}
}
