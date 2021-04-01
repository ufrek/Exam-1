using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DonutLoader : GazeOverEvent
{
    [SerializeField]
    float waitTime = 2;
    // Start is called before the first frame update
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
        StartCoroutine(NextScene());
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(1);
    }
}
