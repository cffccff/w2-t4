using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class ClockScript : MonoBehaviour
{

    [SerializeField] GameObject secondHand;
    [SerializeField] GameObject minuteHand;
    [SerializeField] GameObject hourHand;

    public bool smoothSecondRotation = false;
    public int hour = 0;
    public float secondDegreeSmooth, secondDegree;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RunClock();

        ImproveMoveFeature();
    }
    void RunClock()
    {

        DateTime currentTime = DateTime.Now;

        secondDegree = -(currentTime.Second / 60f) * 360f;



        float minuteDegree = -(currentTime.Minute / 60f) * 360f;

        minuteHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, minuteDegree));

        float hourDegree = -((currentTime.Hour +hour ) / 12f) * 360f;

        hourHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, hourDegree));

        secondDegreeSmooth = -((currentTime.Second + currentTime.Millisecond / 1000f) / 60f) * 360;


    }
    void ImproveMoveFeature()
    {

        if (smoothSecondRotation)
        {

            secondHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, secondDegreeSmooth));
        }

        else secondHand.transform.localRotation = Quaternion.Euler(new Vector3(0, 0, secondDegree));


    }




}
