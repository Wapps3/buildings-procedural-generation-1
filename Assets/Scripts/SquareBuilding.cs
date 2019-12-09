using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareBuilding : MonoBehaviour
{
    public GameObject prefab;

    public float sizeMax;
    public float widthMax;
    public float heighMax;
    public float numberSquare;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numberSquare; i++)
        {
            float sizeActual = sizeMax - (i * Random.Range(0.0f, 1/numberSquare ) * sizeMax);

            float widthActual;
            if(Random.Range(0,1) == 0)
                widthActual = widthMax * Random.Range(-.8f, -.2f);
            else
                widthActual = widthMax * Random.Range(.2f, .8f);

            float heighActual;  
            if (Random.Range(0, 1) == 0)
                heighActual = widthMax * Random.Range(-.8f, -.2f);
            else
                heighActual = widthMax * Random.Range(.2f, .8f);

            GameObject cube = Instantiate(prefab, gameObject.transform.position + new Vector3(heighMax/2, sizeActual/2, widthMax/2), Quaternion.identity,gameObject.transform);
            cube.transform.localScale = new Vector3(heighActual, sizeActual , widthActual  );
        }

        GameObject baseSquare = Instantiate(prefab, gameObject.transform.position + new Vector3(heighMax/2, 0, widthMax/2), Quaternion.identity, gameObject.transform);
        baseSquare.transform.localScale = new Vector3(heighMax, 0.5f, widthMax);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
