using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;
public class player : MonoBehaviour
{
    //public Animator animator;
    Rigidbody2D rb;

    public UIDocument uiDocument;
    public Label scoretext;

    public float thrustforce = 1f;

    private float elapsedTime = 0f;
    private float score = 0f;
    public float scoreMultiplier = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //animator = GetComponent<Animator>();
        //scoretext = uiDocument.rootVisualElement.Q<Label>("ScoreLabel");
        //Debug.Log("Score Label: " + scoretext);

    }

    private void handlemovement()
    {
        if (Mouse.current.leftButton.isPressed)
        {
            //animator.SetBool("isMoving", true);
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            Vector2 direction = (mousePosition - transform.position).normalized;

            transform.up = direction;
            rb.AddForce(direction * thrustforce);
        }
        //else if (animator.GetBool("isMoving"))
        //{
        //    animator.SetBool("isMoving", false);


        //}            //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            //Vector2 direction = (mousePosition - transform.position).normalized;
    }
            void Update()
    {
        //elapsedTime += Time.deltaTime;
        //score = Mathf.FloorToInt(elapsedTime * scoreMultiplier);
        //scoretext.text = "Score: " + score;

        handlemovement();

    }
}
            