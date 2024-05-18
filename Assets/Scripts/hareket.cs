using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    private Animator animator;
    private Rigidbody rigidBody;
    public float movementSpeed = 5f;
    public float jumpForce = 10f;
    private bool isGrounded;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Yürüme animasyonunu kontrol et
        float move = Input.GetAxis("Horizontal");
        animator.SetFloat("Walk", Mathf.Abs(move));

        // Karakteri yatay eksende hareket ettirme
        Vector3 movement = new Vector3(move, 0f, 0f);
        transform.position += movement * Time.deltaTime * movementSpeed;

        // Zıplama kontrolü
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            animator.SetBool("Jump", true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // Karakter yere temas ettiğinde zıplama animasyonunu sıfırla
        if (collision.gameObject.CompareTag("Ground"))
        {
            animator.SetBool("Jump", false);
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // Karakter zeminden ayrıldığında
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
