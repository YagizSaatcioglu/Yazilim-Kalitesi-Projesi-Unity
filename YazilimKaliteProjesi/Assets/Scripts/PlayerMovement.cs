using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Transform playerTransform;
    private GameInput gameInput;
    private Vector2 inputVector;
    void Start()
    {
        playerTransform = GetComponent<Transform>();
        gameInput = FindAnyObjectByType<GameInput>();
        
    }
    // Update is called once per frame
    void Update()
    {
        //inputVector = GameInput.Instance.GetMovementVector();
        inputVector = gameInput.GetMovementVector();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);
        playerTransform.position += moveDir * Time.deltaTime;
        playerTransform.forward = Vector3.Slerp(transform.forward,moveDir,Time.deltaTime);
    }
}
