using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MidiReturn : MonoBehaviour
{
    public GameObject ýnputPanel;
   
    public Image pixelObj;
    public Transform pixelParent;
    public CsvReader csvReader;

    int Count;
    private void Start()
    {

        //StartCoroutine(InstantiatePixel());
        Invoke("ReadCsv",1f);
        
    }

   void ReadCsv()
    {
        Count = csvReader.myMusicList.musicNotes.Length;
        for (int i = 0; i < Count; i++)
        {
            //var index = Array.FindIndex(note_names, row => row.Contains(Notes[i]));
            Image obj = Instantiate(pixelObj, pixelParent);
            obj.color = csvReader.myMusicList.musicNotes[i].color;
            
        }
    }
    IEnumerator InstantiatePixel()
    {
        yield return new WaitForSeconds(3);
        Count = csvReader.myMusicList.musicNotes.Length;
        for (int i = 0; i < Count; i++)
        {
            //var index = Array.FindIndex(note_names, row => row.Contains(Notes[i]));
            Image obj= Instantiate(pixelObj, pixelParent);
            obj.color = csvReader.myMusicList.musicNotes[i].color;
            yield return new WaitForSeconds(0);
        }
       
    }
}
