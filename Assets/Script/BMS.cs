using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BMS : MonoBehaviour
{
    public string title;//title
    public string artist;//artist
    public double bpm;//bpm
    public List<Note> noteList; //note data list
    public int totalNoteCount; // total note 
    public int lnType;//long note type

    void Awake()
    {
        title = "";
        artist = "";
        bpm = 0;
        noteList = new List<Note>();
        totalNoteCount = 0;
        lnType = 0;
    }

    public void addNote(Note note)
    {
        noteList.Add(note);
    }

    // sum
    public void sumTotalNoteCount()
    {
        totalNoteCount++;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // getter setter
    public string getTitle()
    {
        return title;
    }
    public void setTitle(string title)
    {
        this.title = title;
    }
    public string getArtist()
    {
        return artist;
    }
    public void setArtist(string artist)
    {
        this.artist = artist;
    }
    public List<Note> getNoteList()
    {
        return noteList;
    }
    public void setNoteList(List<Note> noteList)
    {
        this.noteList = noteList;
    }
    public double getBpm()
    {
        return bpm;
    }
    public void setBpm(double bpm)
    {
        this.bpm = bpm;
    }
    public int getTotalNoteCount()
    {
        return totalNoteCount;
    }
    public void setTotalNoteCount(int totalCount)
    {
        this.totalNoteCount = totalCount; ;
    }
    public int getLnType()
    {
        return lnType;
    }
    public void setLnType(int lnType)
    {
        this.lnType = lnType; ;
    }

    // debug
    public void debug()
    {
        Debug.Log("title = " + title);
        Debug.Log("artist = " + artist);
        Debug.Log("bpm = " + bpm);
        Debug.Log("noteList = " + noteList.Count);
        Debug.Log("totalNoteCount = " + totalNoteCount);
        Debug.Log("lnType = " + lnType);
    }
}
