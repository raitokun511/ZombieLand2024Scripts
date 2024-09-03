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
    Transform zooCamPosition;
    [SerializeField]
    Transform digCamPosition;

    // Start is called before the first frame update

    void Start()
    {
        InitGameWorld();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            MoveToDigPlace();
        }
    }
    public void Home()
    {
        Debug.Log("Home");
        //ScreenController.Instance.CheckSwipe();
        

    }
    void InitGameWorld()
    {
        
    }
    void MoveToDigPlace()
    {
        Camera.main.transform.position = digCamPosition.position;
    }
    void MoveToMainHouse()
    {
        Camera.main.transform.position = GameManager.mainHousePosition;
    }
    void MoveToNextZoo()
    {

    }
    void MoveToNextFarm()
    {

    }
}
