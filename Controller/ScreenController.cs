using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    private static ScreenController instance;
    public static ScreenController Instance
    {

        get { return instance; }
    }

    private Vector2 startTouchPosition, endTouchPosition;
    private bool isSwiping = false;
    public float swipeThreshold = 50f;
    public float moveSpeed = 5f;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CheckSwipe()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
                isSwiping = true;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTouchPosition = touch.position;
                isSwiping = false;

                Vector2 swipeDelta = endTouchPosition - startTouchPosition;

                if (Mathf.Abs(swipeDelta.x) > swipeThreshold)
                {
                    if (swipeDelta.x > 0)
                    {
                        StartCoroutine(SmoothMove(Vector3.right));
                    }
                    else
                    {
                        StartCoroutine(SmoothMove(Vector3.left));
                    }
                }
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Down");
            startTouchPosition = Input.mousePosition;
            isSwiping = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Mouse Up");
            endTouchPosition = Input.mousePosition;
            isSwiping = false;

            Vector2 swipeDelta = endTouchPosition - startTouchPosition;

            if (Mathf.Abs(swipeDelta.x) > swipeThreshold)
            {
                if (swipeDelta.x > 0)
                {
                    StartCoroutine(SmoothMove(Vector3.left));
                }
                else
                {
                    StartCoroutine(SmoothMove(Vector3.right));
                }
            }
        }
    }
    private IEnumerator SmoothMove(Vector3 direction)
    {
        float screenHeight = Camera.main.orthographicSize * 2;
        float screenWidth = screenHeight * Camera.main.aspect;

        Vector3 startPosition = Camera.main.transform.position;
        Vector3 targetPosition = startPosition + direction * screenWidth; // Di chuyen theo do dai man hinh

        float elapsedTime = 0f;
        while (elapsedTime < 1f)
        {
            Camera.main.transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime);
            elapsedTime += Time.deltaTime * moveSpeed;
            yield return null;
        }
        Camera.main.transform.position = targetPosition;
    }
}
