using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject gameObject;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(SpawnBalls());
        pos = new Vector3(-15, 7, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnBalls()
    {
        while (true)
        {
            yield return new WaitForSeconds(4.0f);
            Instantiate(gameObject, pos, gameObject.transform.rotation);
        }
    }
}
