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
        Count = csvReader.myMusicList.musicNotes.Length;
        //StartCoroutine(InstantiatePixel());
        for (int i = 0; i < Count; i++)
        {
            //var index = Array.FindIndex(note_names, row => row.Contains(Notes[i]));
            Image obj = Instantiate(pixelObj, pixelParent);
            obj.color = csvReader.myMusicList.musicNotes[i].color;
           
        }
    }

   
    IEnumerator InstantiatePixel()
    {
        for (int i = 0; i < Count; i++)
        {
            //var index = Array.FindIndex(note_names, row => row.Contains(Notes[i]));
            Image obj= Instantiate(pixelObj, pixelParent);
            obj.color = csvReader.myMusicList.musicNotes[i].color;
            yield return new WaitForSeconds(0);
        }
       
    }
}
