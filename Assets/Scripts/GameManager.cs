using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isCheck;
    

    public GameObject checkPointPrefab;
    public GameObject hearing_aidPrefab;
    public GameObject dialPlatePrefab;
    public GameObject inGamePrefab;
    public GameObject canvasPrefab;
    public GameObject timerPrefab;
    public AudioSource safeBox;
    public AudioSource getGoal;
    public int rightAngle;
    public static int currentAngle;

    private float checkPointX; 
    private float checkPointY;

    public float currentTime = 3.0f;
    private float invokeTime = 0;
    private bool time;
    public float timeLeft;

    private int skillLevel;



    //private int difficulty;
    private int totalRound;

    public void level(int x)
    {
        totalRound = x;
        inGamePrefab.SetActive(true);
        canvasPrefab.SetActive(false);
        timerPrefab.SetActive(true);


    }



    private void Start()
    {
        //if (difficulty == 1)
        //{
        //    totalRound = 1;
        //}
        //if (difficulty == 2)
        //{
        //    totalRound = 2;
        //}
        //if (difficulty == 3)
        //{
        //    totalRound = 3;
        //}

        checkPointX = Random.Range(-0.57f, 2.65f);
        checkPointY = Random.Range(-1.93f, 2.63f);
        checkPointPrefabPosition();
        rightAngle = Random.Range(0, 36) * 10;

        //Debug.Log(rightAngle);
        currentAngle = 0;



    }

    private void Update()
    {
        timer();
        if(timeLeft <=0)
        {
            inGamePrefab.SetActive(false);
            timerPrefab.SetActive(false);
        }
        if (currentAngle < 0)
        {
            currentAngle += 360;
        }
        
        if (currentAngle > 360)
        {
            currentAngle -= 360;
        }

        //Debug.Log(currentAngle);

        if (totalRound > 0)
        {
            if (Vector3.Distance(hearing_aidPrefab.transform.position, checkPointPrefab.transform.position) < 0.3 && !safeBox.isPlaying && dialPlatePrefab.GetComponent<DialPlate>().isRotate == true)
            {
                safeBox.Play();


            }
            if (Vector3.Distance(hearing_aidPrefab.transform.position, checkPointPrefab.transform.position) < 0.3 &&  currentAngle == rightAngle)
            {

                if (time == false)
                {
                    getGoal.Play();
                    time = true;
                }
                //Debug.Log("Success");
                invokeTime += Time.deltaTime;
                if (invokeTime - currentTime > 0)
                {

                    nextLevel();
                }




            }
            else
            {
                time = false;
                invokeTime = 0;
            }


            //if (currentAngle != rightAngle)
            //{
            //    invokeTime = 0;
            //}

            //Debug.Log(Mathf.Round(dialPlatePrefab.transform.localEulerAngles.x));

            




        }




        //if (Vector3.Distance(hearing_aidPrefab.transform.position, checkPointPrefab.transform.position) < 0.3 && !safeBox.isPlaying&&dialPlatePrefab.GetComponent<DialPlate>().isRotate == true)
        //{
        //    safeBox.Play();


        //}
        //if (currentAngle == rightAngle)
        //{

        //    if (time == false)
        //    {
        //        getGoal.Play();
        //        time = true;
        //    }
        //    //Debug.Log("Success");
        //    invokeTime += Time.deltaTime;
        //    if (invokeTime - currentTime > 0)
        //    {

        //        nextLevel();
        //    }




        //}
        //else
        //{
        //    time = false;
        //    invokeTime = 0;
        //}
            

        //if (currentAngle != rightAngle)
        //{
        //    invokeTime = 0;
        //}

        //Debug.Log(Mathf.Round(dialPlatePrefab.transform.localEulerAngles.x));

        if (totalRound == 0)
        {
            inGamePrefab.SetActive(false);
            timerPrefab.SetActive(false);
        }




    }



    


    void checkPointPrefabPosition()
    {
        checkPointPrefab.transform.position = new Vector3(checkPointX, checkPointY, checkPointPrefab.transform.position.z);
    }

    void nextLevel()
    {
        invokeTime = 0;

        checkPointX = Random.Range(-0.57f, 2.65f);
        checkPointY = Random.Range(-1.93f, 2.63f);
        checkPointPrefabPosition();
        rightAngle = Random.Range(0, 36) * 10;

        //Debug.Log(rightAngle);
        currentAngle = 0;
        totalRound--;


    }

    void timer()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            inGamePrefab.SetActive(false);
            timerPrefab.SetActive(false);
        }
    }


   



}
