using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UIElements;

public class HomeController : MonoBehaviour
{
    [SerializeField]
    AssetsManager assetsManager;
    [SerializeField]
    Transform zooTransformObject;
    // Start is called before the first frame update

    void Start()
    {
        InitGameWorld();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Home()
    {
        Debug.Log("Home");
        //ScreenController.Instance.CheckSwipe();
        

    }
    void InitGameWorld()
    {
        
    }
    
}
