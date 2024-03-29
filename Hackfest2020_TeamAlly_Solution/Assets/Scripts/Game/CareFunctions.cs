﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CareFunctions : MonoBehaviour
{
    [Header("Bars")]
    public GameObject sunBar;

    [Header("Care Item Parents")]
    public GameObject wateringPailParent;
    public GameObject fertilizePlantParent;
    public GameObject pesticideParent;
    public GameObject headphonesParent;
    public GameObject shearsParent;

    [Header("Care Items")]
    public GameObject sunSlider;

    [Header("Other")]
    public GameObject spotLight;
    private SpriteRenderer lightOpacity;
    public TextMeshProUGUI opacityLevelText;

    // Start is called before the first frame update
    void Start()
    {
        wateringPailParent.SetActive(false);
        sunSlider.SetActive(false);
        fertilizePlantParent.SetActive(false);
        pesticideParent.SetActive(false);
        headphonesParent.SetActive(false);
        shearsParent.SetActive(false);

        opacityLevelText.gameObject.SetActive(false);
        lightOpacity = spotLight.GetComponent<SpriteRenderer>();

        sunSlider.GetComponent<Slider>().value = lightOpacity.color.a;
    }

    public void waterPlant()
    {
        wateringPailParent.SetActive(true);      
    }

    public void sunSliderShow()
    {
        sunSlider.SetActive(true);
    }

    public void adjustLight(float opacity)
    {
        Color tmp = lightOpacity.color;

        tmp.a = opacity;

        lightOpacity.color = tmp;

        opacityLevelText.gameObject.SetActive(true);
        opacityLevelText.text = Mathf.RoundToInt(opacity * 100) + "%";
    }

    public void sunSliderHide()
    {
        sunBar.GetComponent<Healthbar>().addhealth(20);
        opacityLevelText.gameObject.SetActive(false);
        sunSlider.SetActive(false);
    }

    public void fertilizePlant()
    {
        fertilizePlantParent.SetActive(true);
    }

    public void sprayPesticide()
    {
        pesticideParent.SetActive(true);
    }

    public void headphonesShow()
    {
        headphonesParent.SetActive(true);
    }

    public void shearsShow()
    {
        shearsParent.SetActive(true);
    }
}
