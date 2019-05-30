using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject upper=null;
    public GameObject lower=null;
    public float repeatRate = 2f;
    public Transform lowerTransform,upperTransform;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1f, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnObjects()
    {
        
        float randomOffset = Random.RandomRange(0,2.5f);
        
        Vector3 lowerVector = new Vector3(lowerTransform.position.x, lowerTransform.position.y - randomOffset , lowerTransform.position.z);
        Vector3 upperVector = new Vector3(upperTransform.position.x, upperTransform.position.y + randomOffset, upperTransform.position.z);

        GameObject lowerPart = Instantiate(lower, lowerVector , Quaternion.Inverse(Quaternion.identity));
        GameObject upperPart = Instantiate(upper, upperVector , Quaternion.identity);

        Destroy(lowerPart, 20);
        Destroy(upperPart, 20);
    }
}
