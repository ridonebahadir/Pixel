using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Reflection;
using UnityEditor;

public class CsvReader : MonoBehaviour
{
    public TextAsset textAssetData;

    [System.Serializable]
    public class MusicNotes
    {
        public int count;
        public int channel;
        public int notenumber;
        public int velocity;
        public Color color;
    }

    [System.Serializable]
    public class MusicList
    {
        public MusicNotes[] musicNotes;
    }
    public Gradient gradient;
    public MusicList myMusicList = new MusicList();
    void Start()
    {
        ReadCSV();
        
    }
    int tableSize;
    void ReadCSV()
    {
        string[] data = textAssetData.text.Split(new string[] { ";", "\n" }, StringSplitOptions.None);
        tableSize = data.Length / 4 - 1;
        myMusicList.musicNotes = new MusicNotes[tableSize];
        for (int i = 0; i < tableSize; i++)
        {
            myMusicList.musicNotes[i] = new MusicNotes();
            myMusicList.musicNotes[i].count = int.Parse(data[4 * (i + 1)]);
            myMusicList.musicNotes[i].channel =int.Parse(data[4 * (i + 1)+1]);
            myMusicList.musicNotes[i].notenumber =int.Parse(data[4 * (i + 1)+2]);
            myMusicList.musicNotes[i].velocity =int.Parse(data[4 * (i + 1)+3]);





            H = (0.9972222f * myMusicList.musicNotes[i].notenumber) / 100;
            S = 1;
            V = 1;


            Debug.Log("H = " + H);

           
            myMusicList.musicNotes[i].color = Color.HSVToRGB(H, S, V);
            
            //myMusicList.musicNotes[i].color.a = 0.1f+(0.9999f*myMusicList.musicNotes[i].velocity)/100;



        }
    }
     float H, S, V;
    //private void Update()
    //{

    //    Color.RGBToHSV(color, out H, out S, out V);
    //    Debug.Log("H: " + H + " S: " + S + " V: " + V);

    //    Change = Color.HSVToRGB(H, S, V);
    //}
     Color color;
    
}
    


   





