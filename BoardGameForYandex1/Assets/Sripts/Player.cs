using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform[] points;
    public int currentIndex = 0;
    public float speed;
    public bool move = false;
    public int target;

    void Update()
    {
        Moving(target);
    }

    void Moving(int x)
    {
        if (currentIndex != target)
        {
            if (currentIndex < target)
            {
                Transform targetPoint = points[currentIndex];

                transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

                if (transform.position == targetPoint.position)
                {
                    currentIndex++;
                }
            }
            if (currentIndex > target)
            {
                Transform targetPoint = points[currentIndex-1];
             
                transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, speed * Time.deltaTime);

                if (transform.position == targetPoint.position)
                {
                    currentIndex--;
                }
            }
        }
    }
}
