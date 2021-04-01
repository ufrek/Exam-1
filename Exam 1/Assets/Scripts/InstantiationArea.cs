using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationArea : MonoBehaviour
{
    [SerializeField]
    GameObject duplicationPrefab;
    public int tankSize = 70; // This parameter is very important to control the range of fish

    // Start is called before the first frame update
    void Start()
    {
        //on click do this for duuplication
     
        
        Vector3 pos = new Vector3(Random.Range(-tankSize, tankSize), //This parameter is important to control different initial positions of different fish groups
                                    Random.Range(-tankSize, tankSize),
                                    Random.Range(-tankSize, tankSize));
        pos = pos + this.transform.position;
        GameObject go = (GameObject)Instantiate(duplicationPrefab, pos, duplicationPrefab.transform.rotation);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
