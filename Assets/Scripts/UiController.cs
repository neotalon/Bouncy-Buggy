﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiController : MonoBehaviour
{
    public static UiController Instance;

    [SerializeField]
    Canvas canvas;

    [SerializeField]
    TextMeshProUGUI distanceText;
    
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        canvas.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDistanceText(float f)
    {
        distanceText.text = Mathf.Round(f / 10f).ToString() + "m";
    }
}