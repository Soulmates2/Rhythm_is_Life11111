using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public int bar;//마디 number
    public int channel;//channel number
    public List<int> noteData;//note information

    private void Awake()
    {
        bar = 0;
        channel = 0;
        noteData = new List<int>();
    }

    public int getBar()
    {
        return bar;
    }

    public void setBar(int bar)
    {
        this.bar = bar;
    }
    
    public int getChannel()
    {
        return channel;
    }
    public void setChannel(int channel)
    {
        this.channel = channel;
    }
    public List<int> getNoteData()
    {
        return noteData;
    }

    public void setNoteData(List<int> noteData)
    {
        this.noteData = noteData;
    }

    // debug
    public void debug()
    {
        //Debug.Log("bar = " + bar);
        //Debug.Log("channel = " + channel);
       // foreach (int note in noteData)
        //{
          //  Debug.Log("note = " + note);
       // }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
