using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class BeatScript : MonoBehaviour
{
    public static int FPS = 50;

    private int f;
    private int beatFrame;
    private int beatLength;
    private int upperBoundFrame;
    private int lowerBoundFrame;

    public int BPM; //beats per minute
    public int iFrames; //number of frames that accept input. Presumed to begin on the same frame as the beat;
    public int iShift;  //number of frames the iFrames begin before the beat. NOTE: negative shifts are unwise.
    public AudioSource audio; //for testing purposes.

    // Start is called before the first frame update
    void Start()
    {
        beatLength = FPS*60/BPM; //get number of frames per beat
        Debug.Log("Frames per Beat: " + beatLength);
        lowerBoundFrame = (beatLength - iFrames) / 2; //get first iFrame
        upperBoundFrame = lowerBoundFrame + iFrames; // get last iFrame;
        beatFrame = lowerBoundFrame + iShift; //get the frame on which the beat occures.
        f = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        f++;

        if (f == beatFrame)
            executeOnBeat();

        if (f == beatLength)
            f = 0;
    }

    //for any events that must occure exactly on beat;
    void executeOnBeat() 
    {
        audio.Play(0);
    }

    //test if an action occures during a beats iFrames.
    public bool isOnBeat() 
    {
        return (f >= lowerBoundFrame && f <= upperBoundFrame);
    } 
}
