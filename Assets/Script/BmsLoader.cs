using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

public class BmsLoader : MonoBehaviour
{
    public string bmsFileName = "tutorial.bme";
    public bool isFinishLoad=false;
    public BMS bms;
    public List<GameObject> objectList;
    // Start is called before the first frame update
    void Start()
    {
        BmsLoad();
    }

    private void BmsLoad()
    {
        objectList = new List<GameObject>();
        bms = gameObject.AddComponent<BMS>();
        string[] lineData = File.ReadAllLines("Assets/BmsFiles/" + bmsFileName);
        foreach(string line in lineData)
        {
            if(line.StartsWith("#"))
            {
                string[] data = line.Split(' ');

                // exception
                if (data[0].IndexOf(":") == -1 && data.Length == 1)
                {
                    continue;
                }

                // header field
                if (data[0].Equals("#TITLE"))
                {
                    bms.setTitle(data[1]);
                }
                else if (data[0].Equals("#ARTIST"))
                {
                    bms.setArtist(data[1]);
                }
                else if (data[0].Equals("#BPM"))
                {
                    bms.setBpm(double.Parse(data[1]));
                }
                else if (data[0].Equals("#PLAYER"))
                {
                }
                else if (data[0].Equals("#GENRE"))
                {
                }
                else if (data[0].Equals("#PLAYLEVEL"))
                {
                }
                else if (data[0].Equals("#RANK"))
                {
                }
                else if (data[0].Equals("#TOTAL"))
                {
                }
                else if (data[0].Equals("#VOLWAV"))
                {
                }
                else if (data[0].Equals("#MIDIFILE"))
                {
                }
                else if (data[0].Equals("#WAV01"))
                {
                }//
                else if (data[0].Equals("#BMP01"))
                {
                }//
                else if (data[0].Equals("#STAGEFILE"))
                {
                }
                else if (data[0].Equals("#VIDEOFILE"))
                {
                }
                else if (data[0].Equals("#BGA"))
                {
                }
                else if (data[0].Equals("#STOP"))
                {
                }
                else if (data[0].Equals("#LNTYPE"))
                {
                    bms.setLnType(int.Parse(data[1]));
                }
                else if (data[0].Equals("#LNOBJ"))
                {
                }
                else
                {
                    // data field
                    int bar = 0; // node key
                    Int32.TryParse(data[0].Substring(1, 3), out bar);

                    int channel = 0; // node channel
                    Int32.TryParse(data[0].Substring(4, 2), out channel);

                    string noteStr = data[0].Substring(7);
                    List<int> noteData = getNoteDataOfStr(noteStr);

                    Note note = gameObject.AddComponent<Note>();
                    note.setBar(bar);
                    note.setChannel(channel);
                    note.setNoteData(noteData);
                    note.debug();
         
                    bms.addNote(note);
                    isFinishLoad = true;
                }
            }
        }
        if(isFinishLoad)
        {
            foreach (Note note in bms.getNoteList())
            {
                GameObject n = GameObject.CreatePrimitive(PrimitiveType.Cube);
                n.transform.localScale += new Vector3(4, 1, 0);
                switch (note.channel)
                {
                    case 11:
                        n.GetComponent<Renderer>().material.color = Color.red;
                        n.transform.position = new Vector3(-10, -15, 30+note.bar*10);
                        n.tag = "red";
                        break;
                    case 12:
                        n.GetComponent<Renderer>().material.color = Color.green;
                        n.transform.position = new Vector3(-5, -15, 30 + note.bar * 10);
                        n.tag = "green";
                        break;
                    case 13:
                        n.GetComponent<Renderer>().material.color = Color.blue;
                        n.transform.position = new Vector3(0, -15, 30 + note.bar * 10);
                        n.tag = "blue";
                        break;
                    case 14:
                        n.GetComponent<Renderer>().material.color = Color.black;
                        n.transform.position = new Vector3(5, -15, 30 + note.bar * 10);
                        n.tag = "black";
                        break;
                    case 15:
                        n.GetComponent<Renderer>().material.color = Color.yellow;
                        n.transform.position = new Vector3(10, -15, 30 + note.bar * 10);
                        n.tag = "yellow";
                        break;
                }
                objectList.Add(n);
            }
        }
    }
    private List<int> getNoteDataOfStr(string str)
    {
        string tempStr = str;
        List<int> noteList = new List<int>();

        while (true)
        {
            if (tempStr.Length > 2)
            {
                int data = 0;
                Int32.TryParse(tempStr.Substring(0, 2), out data);

                noteList.Add(data);
                tempStr = tempStr.Substring(2);
            }
            else
            {
                int data = 0;
                Int32.TryParse(tempStr, out data);
                noteList.Add(data);
                break;
            }
        }

        // 총노트수 증가
        foreach (int note in noteList)
        {
            if (note != 0)
            {
                bms.sumTotalNoteCount();
            }
        }

        return noteList;
    }

    void Update()
    {
        foreach(GameObject o in objectList)
        {
            if (o!=null&&o.tag == "destroy") Destroy(o);
            if(o!=null)o.transform.position += new Vector3(0f, 0f, 20 * Time.deltaTime * (-1));
        }
    }
}
