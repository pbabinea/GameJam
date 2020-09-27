using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public static int FPS = 50;
    private int beatLength;
    private int frame;
    private int index = 0;
    private List<int> lanes = new List<int>{0,4,-4,-2,2,0,2,-2,4,0,-4};
    public GameObject blockPrefab;
    public GameObject antag;
    public float xPos;
    public float spawnRate;
    public float spawnDelay;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

        beatLength = FPS * 60 / antag.GetComponent<BeatScript>().BPM; //get number of frames per beat
        frame = beatLength / 2;

        /*for(int i = 0; i < lanes.Count; i++)
        {
            float sample = Mathf.PerlinNoise(xPos, 0) * 4;
            sample = Mathf.Round(sample);
            lanes[i] = sample;
        }*/
        //I wanted to try to randomly generate some of the positions, but the code has other ideas, i guess :/
    }
        

    private void FixedUpdate()
    {
        frame++;
        if (frame >= beatLength)
        {
            //Instantiate(blockPrefab, new Vector3(xPos, 0, 0), Quaternion.identity);
            Debug.Log("index" + index);
            Spawn(lanes[index]);
            index++;
            //Spawn(lanes[index]);
            frame = 0;
            if (index == lanes.Count)
            {
                index = 0;
            }
        }
        
    }

    //void Spawn()
    void Spawn(float lane)
    {
        //GameObject newBlock = Instantiate(blockPrefab, spawnPoint);
        GameObject newBlock = Instantiate(blockPrefab, new Vector3(xPos, lane, 0), Quaternion.identity);       
    }
    //void SpawnTwoAdjacent
    //void SpawnSpeedy
    //void SpawnLongBoy
    //void SpawnDouble
}
