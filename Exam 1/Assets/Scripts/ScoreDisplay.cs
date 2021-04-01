using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(TextMesh))]
public class ScoreDisplay : MonoBehaviour
{
    public TextMesh tScore;
    int totalScore = 0;
    public static ScoreDisplay S;
    // Start is called before the first frame update
    void Start()
    {
        S = this;
        tScore = GetComponent<TextMesh>();
        totalScore = 0;
        UpdateText();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore(int i)
    {
        totalScore += i;
        UpdateText();
    }

    void UpdateText()
    {
        tScore.text = "Score: " + totalScore;
    }


}
