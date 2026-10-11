using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2[] waypoints;
    private int index = 0;
    public float speed = 5f;

    void Update()
    {
        if (waypoints.Length > 0 && index < waypoints.Length)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[index], speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, waypoints[index]) < 0.1f)
            {
                index++;
            }
        }
    }
}