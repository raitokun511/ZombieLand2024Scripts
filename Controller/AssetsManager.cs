using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetsManager : MonoBehaviour
{

    public GameObject[] normalZombies;

    public GameObject[] superZombies;
   
    public GameObject[] expertZombies;

    public GameObject[] ultiZombies;

    public GameObject[] habitat;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
