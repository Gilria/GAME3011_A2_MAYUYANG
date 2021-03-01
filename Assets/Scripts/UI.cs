using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UI : MonoBehaviour
{
    public Text timeText;
    private GameManager gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
        
    }
    private void Update()
    {
        timeText.text = ((int)gm.timeLeft).ToString();
    }
}
