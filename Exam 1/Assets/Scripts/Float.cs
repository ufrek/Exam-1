using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Float : MonoBehaviour
{
    [SerializeField]
    int rotationSpeed = 130; //how many degrees per second
    [SerializeField]
    float bounceSpeed = 3;
    [SerializeField]
    float bounceHeight = 5f;
    [SerializeField]
    float yOffset;
    [SerializeField]
    [Range(0, 2* Mathf.PI)]
    float periodicOffset;
    // Start is called before the first frame update
    bool isFloating = true;
    void Start()
    {
        int rand = Random.Range(0, 2);
        if (rand == 0)
            isFloating = true;
        else
            isFloating = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFloating)
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
            Vector3 pos = this.transform.position;
            transform.position = new Vector3(pos.x, yOffset + (Mathf.Sin(Time.time * bounceSpeed + periodicOffset) * bounceHeight), pos.z);
        }
       
    }

    public void SpinFaster()
    {
        StartCoroutine(Spin());
    }

    IEnumerator Spin()
    {
        bounceSpeed *= 2;
        yield return new WaitForSeconds(2);
        bounceSpeed /= 2;
    }
}
