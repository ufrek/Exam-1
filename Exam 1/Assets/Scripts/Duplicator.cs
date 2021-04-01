using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicator : GazeOverEvent
{
    [SerializeField]
    GameObject closedPrefab;
    [SerializeField]
    float closedYOffset = .1f;

    GameObject duplicationPrefab;
    private const float _minObjectDistance = 2.5f;
    private const float _maxObjectDistance = 3.5f;
    private const float _minObjectHeight = 0.5f;
    private const float _maxObjectHeight = 3.5f;

    public static int donutDupes = 0;
    public static int coffeeDupes = 0;
    private void Awake()
    {
        
        duplicationPrefab = transform.parent.gameObject;
    }
    public override void Hovering()
    {
        base.Hovering();
    }

    public override void NotHovering()
    {
        base.NotHovering();
    }

    public override void OnClick()
    {
        base.OnClick();

        float angle = Random.Range(-90, 90);
        float distance = Random.Range(_minObjectDistance, _maxObjectDistance);
        float height = Random.Range(_minObjectHeight, _maxObjectHeight);
        Vector3 newPos = new Vector3(Mathf.Cos(angle) * distance, height,
                                     Mathf.Sin(angle) * distance);

        if (this.transform.parent.gameObject.tag.Equals("Donut"))
        {
            if (donutDupes < 3)
            {
                GameObject newDupe = GameObject.Instantiate(duplicationPrefab);
                newDupe.transform.localPosition = newPos;
                newDupe.GetComponentInChildren<Float>().SpinFaster();
                donutDupes += 1;
                ScoreDisplay.S.addScore(100);
            }
            else
            {
                Vector3 tPos = this.transform.position;
               // tPos = new Vector3(newPos.x, newPos.y + closedYOffset, newPos.z);
                GameObject closedText = GameObject.Instantiate(closedPrefab);
                //closedText.transform.position = tPos;
            }

        }
        else if (this.transform.parent.gameObject.tag.Equals("Coffee"))
        {
            if (coffeeDupes < 3)
            {
                GameObject newDupe = GameObject.Instantiate(duplicationPrefab);
                newDupe.GetComponentInChildren<Float>().SpinFaster();
                newDupe.transform.localPosition = newPos;
                coffeeDupes += 1;
                ScoreDisplay.S.addScore(200);
            }
            else 
            {
                Vector3 tPos = this.transform.position;
               // tPos = new Vector3(newPos.x, newPos.y + closedYOffset, newPos.z);
                GameObject closedText = GameObject.Instantiate(closedPrefab);
                //closedText.transform.position = tPos;
            }
        }
      
   
    }

}
