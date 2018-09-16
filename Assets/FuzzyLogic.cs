using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuzzyLogic : MonoBehaviour {

    public InputField healthInput;
    public Text healthyText;
    public Text hurtText;
    public Text criticalText;

    float healthVal, criticalVal, hurtVal;

    public AnimationCurve healthy;
    public AnimationCurve hurt;
    public AnimationCurve critical;


    private void Start()
    {
        SetTexts();
    }

    public void EvaluateParameter()
    {
        if (string.IsNullOrEmpty(healthInput.text)) return;

        float health = float.Parse(healthInput.text);

        healthVal = healthy.Evaluate(health);
        hurtVal = hurt.Evaluate(health);
        criticalVal = critical.Evaluate(health);

        SetTexts();
    }

    private void SetTexts()
    {
        healthyText.text = healthVal.ToString();
        criticalText.text = criticalVal.ToString();
        hurtText.text = hurtVal.ToString();
    }
}
