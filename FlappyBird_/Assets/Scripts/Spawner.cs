using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Birdy BirdScript;
    public GameObject Tubes;
    public float Height;
    public float Time;

    private void Start()
    {
        StartCoroutine(SpawnObject(Time));
    }

    public IEnumerator SpawnObject(float time)
    {
        while (!BirdScript.isDead)
        {
           
            Instantiate(Tubes, new Vector3(3,Random.Range(-Height,Height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
        

    }
}
