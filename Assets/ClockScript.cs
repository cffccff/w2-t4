using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ClockScript : MonoBehaviour
{

    [SerializeField] GameObject secondHand;
    [SerializeField] GameObject minuteHand;
    [SerializeField] GameObject hourHand;


     public int hour = 0;
    public float rotationSeconds, secondsDegree;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RunClock();
       

    }
    void RunClock()
    {

        DateTime currentTime = DateTime.Now;

      float secondsDegree = -(currentTime.Second / 60f) * 360f;

        secondHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, secondsDegree));

        float minuteDegree = -(currentTime.Minute / 60f) * 360f;

        minuteHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, minuteDegree));

        float hourDegree = -((currentTime.Hour) / 12f) * 360f;

        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, hourDegree));

        
       

    }
    void ImproveMoveFeature()
    {
        
    }




}
