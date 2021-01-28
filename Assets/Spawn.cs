using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject milkPrefab;
    public GameObject cookiePrefab;
    public GameObject parentSpawnGo;
    public float nextSpawn = 4.0f;
    
    private float spawnRate = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        SpawnTheMilk();
        SpawnTheCookie();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnTheMilk();
            SpawnTheCookie();
        }
    }

    private void SpawnTheMilk()
    {
        var clones = Instantiate(milkPrefab);
        clones.GetComponent<Transform>().SetParent(parentSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    private void SpawnTheCookie()
    {
        var clones = Instantiate(cookiePrefab);
        clones.GetComponent<Transform>().SetParent(parentSpawnGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

}
