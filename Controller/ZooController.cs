using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZooController : MonoBehaviour
{
    public AssetsManager assetsManager;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(InitZoo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator InitZoo()
    {
        float screenHeight = Camera.main.orthographicSize * 2;
        float screenWidth = screenHeight * Camera.main.aspect;
        float widthZoo = screenWidth;
        float zooPosition = 0;
        foreach (var zomZoo in GameManager.listZombie)
        {
            GameObject habitatInstance = Instantiate(assetsManager.habitat[0], gameObject.transform);
            habitatInstance.transform.position = new Vector3(zooPosition, habitatInstance.transform.position.y, habitatInstance.transform.position.z);

            if (GameManager.zooBounds.Equals(default(Bounds)))
            {
                GameManager.zooBounds = TransformUtils.GetBounds(habitatInstance);
            }
            GameObject zombieInstance = Instantiate(assetsManager.normalZombies[zomZoo], gameObject.transform);
            zombieInstance.transform.position = habitatInstance.transform.position + new Vector3(GameManager.zooBounds.size.x, 0, GameManager.zooBounds.size.z / 2f);
            zooPosition += widthZoo;
            yield return null;
        }
    }
}
