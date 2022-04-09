using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MidiReturn : MonoBehaviour
{
    public GameObject ýnputPanel;
    public InputField ýnputField;
    public String[] Notes;
    public Color[] color;
    //public Image[] image;
    public Image pixelObj;
    public Transform pixelParent;
   

    String[] note_names = { "|", "do", "re", "mi", "fa", "so", "la", "si" };
    //public String getNoteFromMidiNumber(int midiNote)
    //{
    //    String[] note_names = {" ", "Do", "Re", "Mi", "Fa", "So", "La", "Si"};
    //    return note_names[midiNote];
    //}
    public Color getNoteFromMidiColor(int midiNote)
    {
        Color[] note_color = {  color[0], color[1], color[2], color[3],color[4],color[5],color[6], color[7]};
        return note_color[midiNote];
    }
   
    public void ConvertNotes()
    {
        Notes = ýnputField.text.Split(' ');
        ýnputPanel.SetActive(false);
        StartCoroutine(InstantiatePixel());
       
        
        
    }
    IEnumerator InstantiatePixel()
    {
        for (int i = 0; i < Notes.Length; i++)
        {
            var index = Array.FindIndex(note_names, row => row.Contains(Notes[i]));
            Image obj= Instantiate(pixelObj, pixelParent);
            obj.color = getNoteFromMidiColor(index);
            yield return new WaitForSeconds(1.5f);
        }
       
    }
}
