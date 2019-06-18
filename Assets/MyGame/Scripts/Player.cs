using UnityEngine;

public class Player : MonoBehaviour
{
	private const string AXISHORIZONTAL = "Horizontal";
	private float moveSpeed = 3.0f;
    private float moveMaxPos = 300f;

	private void Move()
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, -moveMaxPos, moveMaxPos);

        transform.position = new Vector2(newPosX, transform.position.y);
    }
	
	void Update ()
    {
		Move();
	}
}
