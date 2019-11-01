<<<<<<< HEAD
﻿using System;
using System.Collections;
using UnityEngine;

public class Rotations : MonoBehaviour
{
    private int xAngle, yAngle = 0;
    private Quaternion target;
    private bool trigger;
    private IEnumerator coroutine;
    
    private void Start()
    {
        coroutine = WaitAndPrint(4f);
        StartCoroutine(coroutine);
    }

    private void Awake()
    {
        trigger = false;
        var localEulerAngles = transform.localEulerAngles;
        target = Quaternion.Euler(localEulerAngles.x, localEulerAngles.y, localEulerAngles.z);
=======
﻿using UnityEngine;

public class Rotations : MonoBehaviour
{

    private GameObject obj;
    private int angle;
    private bool n, e, s, w;

    private void Awake()
    {
        obj = this.gameObject;
>>>>>>> 2641dfec2f924a6e63cf98701e31dcb47c16d77c
    }

    private void Update()
    {
<<<<<<< HEAD
        if (trigger)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 10);
        }
    }

    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            trigger = false;
        }
    }
    
    public void DoRotationY(int yAngles)
    {
        trigger = true;
        yAngle = yAngles;

        var localEuler = transform.localEulerAngles;
        target = Quaternion.Euler(localEuler.x , localEuler.y + yAngles, localEuler.z);
    }
    
    public void DoRotationX(int xAngles)
    {
        trigger = true;
        yAngle = xAngles;

        var localEuler = transform.localEulerAngles;

        if (transform.rotation.x > 0.7 || transform.rotation.x < -0.7)
        {
            target = Quaternion.Euler(0 , 0, 0);
        }
        else
        {
            target = Quaternion.Euler(localEuler.x + xAngles , 0, 0);
        }
        
=======
        
    }

    public void DoRotation(int angle)
    {
        this.angle = angle;
        obj.transform.Rotate(0, angle, 0);
>>>>>>> 2641dfec2f924a6e63cf98701e31dcb47c16d77c
    }
}
