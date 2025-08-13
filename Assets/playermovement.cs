using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerLaneMovement : MonoBehaviour
{
    public float laneDistance = 2.5f;
    public float moveSpeed = 10f;
    private int currentLane = 1;

    private void Update()
    {
        moverightandleft();
    }














    void moverightandleft()// this code change player lane when left/right arrows are clicked, then moves player by changing only the x axis
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentLane = Mathf.Max(0, currentLane - 1);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentLane = Mathf.Min(2, currentLane + 1);
        }

        float targetX = (currentLane - 1) * laneDistance;
        float newX = Mathf.Lerp(transform.position.x, targetX, moveSpeed * Time.deltaTime);

        transform.position = new Vector3(
            newX,
            transform.position.y,
            transform.position.z
        );
    }





}