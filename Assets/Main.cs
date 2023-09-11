using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Main : MonoBehaviour
{
    [Serializable]
    public class _2dArray
    {
        public Sprite[] arr = new Sprite[3];
    }

    public _2dArray[] test = new _2dArray[3];
    public Sprite[] CatThumnails = new Sprite[3];
    public Sprite[] BoxThumnails = new Sprite[3];
    public Image PortImage;
    public Image CatThumnail;
    public Image BoxThumnail; 
    public int CatIndex = 0;
    public int BoxIndex = 0;
    public enum Type {cat, box}
    
    
    // Start is called before the first frame update
    void Start()
    {
        SetPortrait();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPortrait(){
        PortImage.sprite = test[CatIndex].arr[BoxIndex];
        CatThumnail.sprite = CatThumnails[CatIndex];
        BoxThumnail.sprite = BoxThumnails[BoxIndex];
    }
    public void ChangeCatIndex(int increase) {
        CatIndex += increase;
        if (CatIndex >2) {
            CatIndex = 0;
        }
        else if (CatIndex < 0) {
            CatIndex = 2;
        }
        SetPortrait( );
    }
    public void ChangeBoxIndex(int increase){
        BoxIndex += increase;
        if (BoxIndex >2) {
            BoxIndex = 0;
        }
        else if (BoxIndex < 0) {
            BoxIndex = 2;
        }
        SetPortrait( );
    }
}
