using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDiamond : MonoBehaviour
{
    public GameObject diamond;
    public float width;
    public float maxTime;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(diamond);
        newPipe.transform.position = transform.position + new Vector3(Random.Range(-width, width), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime){
            GameObject newPipe = Instantiate(diamond);
            newPipe.transform.position = transform.position + new Vector3(Random.Range(-width, width), 0);
            Destroy(newPipe, 10f);
            timer = 0;
        }

        timer += Time.deltaTime;

    }
}
