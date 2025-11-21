using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float moveSpeed = 15.0f;
    [SerializeField] float jumpPower = 10.0f;
    [SerializeField] MeshRenderer normalMesh;
    [SerializeField] MeshRenderer jumpMesh;

    [SerializeField] LayerMask groundMask;

    Vector2 moveDir = new();


    private void Update()
    {
        moveDir.x = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        Vector3 speed = Vector3.zero;
        speed.x = moveDir.x * moveSpeed;
        bool grounded = IsGrounded();

        if (grounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                speed.y = jumpPower;
            }
            normalMesh.enabled = true;
            jumpMesh.enabled = false;
        }
        else
        {
            normalMesh.enabled = false;
            jumpMesh.enabled = true;
        }
            rb.linearVelocity = speed;
    }

    public bool IsGrounded()
    {
        Ray ray = new (rb.position, Vector3.down);
        if (Physics.Raycast(ray,  out RaycastHit hit, 1.1f, groundMask))
        {
            return true;
        }
        return false;
    }
}
