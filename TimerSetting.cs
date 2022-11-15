using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerSetting : MonoBehaviour
{
    public Text TextTimer;
    public float waktu = 0;
    // Start is called before the first frame update
    void setText(){
        int Menit = Mathf.FloorToInt(waktu / 60);
        int Detik  = Mathf.FloorToInt(waktu % 60);
        TextTimer.text =  Menit.ToString("00") +":"+Detik.ToString("00") ;
    }
    float s;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     setText();   
     s += Time.deltaTime;
     if(s >= 1){
        waktu++;
        s = 0;
     }
    }
}
