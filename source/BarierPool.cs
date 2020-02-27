using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarierPool : MonoBehaviour
{
    public int barierPoolSize = 10;
    public GameObject barierPrefab;
    public float spawnRate = 4f;
    public float barierMin = 25f;
    public float barierMax = 35f;

    private GameObject[] bariers;
    private Vector2 objectPoolPosition = new Vector2(-45f, -75f);
    private float timeSinceLastSpawned;
    public int ist = 0;

    private int currentBarier = 0;

    public float fireRate = 0.00000005f;
    private float nextFire = 0.0f;

    // Start is called before the first frame update
    void Awake()
    {
        ist = PlayerPrefs.GetInt("num", ist);
        if (ist == 1)
        {
            // spawnRate = PlayerPrefs.GetFloat("spawn", spawnRate);
            spawnRate = GameControl.spawnrate;
        }


        bariers = new GameObject[barierPoolSize];
        for (int i = 0; i < barierPoolSize; i++)
        {
            bariers[i] = (GameObject)Instantiate(barierPrefab, objectPoolPosition, Quaternion.identity);
        }


    }





    // Update is called once per frame
    void Update()
    {
        timeSinceLastSpawned += Time.deltaTime;

        if (GameControl.instance.gameOver == false && timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnXPosition = Random.Range(barierMin, barierMax);

            bariers[currentBarier].transform.position = new Vector2(spawnXPosition, -1.30f);

            currentBarier++;
            if (currentBarier >= barierPoolSize)
            {
                currentBarier = 0;
            }
        }

        if (GameControl.instance.gameOver == false && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            spawnRate = spawnRate - 0.1f;
        }

        if (GameControl.instance.gameOver == true)
        {

            //PlayerPrefs.SetFloat("spawn",spawnRate);
            GameControl.spawnrate = spawnRate;
        }
    }
}
