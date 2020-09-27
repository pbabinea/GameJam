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
    public GameObject player;
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
        //I wanted to try to randomly generate some of the positions, but fate would not have it :/
    }
        

    private void FixedUpdate()
    {
        frame++;
        if (frame >= beatLength)
        {
            if(index%3==0)
            {
                if (index % 2 == 0)
                {
                    SpawnTwo(lanes[index]);
                } else
                {
                    SpawnDouble(lanes[index]);
                }
            }
            Spawn(lanes[index]);
            index++;
            frame = 0;
            if (index == lanes.Count)
            {
                index = 0;
            }
        }
        
    }

    void Spawn(float lane)
    {
        GameObject newBlock = Instantiate(blockPrefab, new Vector3(xPos, lane, 0), Quaternion.identity);
        newBlock.GetComponent<BlockScript>().player = player;
    }

    void SpawnTwo(float lane) //spawns two at same beat, different lanes
    {
        GameObject newBlock = Instantiate(blockPrefab, new Vector3(xPos+5, lane, 0), Quaternion.identity);
        newBlock.GetComponent<BlockScript>().player = player;
    }

    void SpawnDouble(float lane) //spawns one on-beat and one in between beats
    {
        GameObject newBlock1 = Instantiate(blockPrefab, new Vector3(xPos, lane, 0), Quaternion.identity);
        GameObject newBlock2 = Instantiate(blockPrefab, new Vector3(xPos+(15/2), lane, 0), Quaternion.identity);
        newBlock1.GetComponent<BlockScript>().player = player;
        newBlock2.GetComponent<BlockScript>().player = player;
    }
    //void SpawnSpeedy
    //void SpawnLongBoy
    //these didn't make it in :(
}
