using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField]
    private float speed = 10;

    public GameObject test;

    InputActionManager inputManager;

    Rigidbody2D rb2D;

    Vector2 movement;

    bool setMenu = false;

    private void Awake()
    {
        try
        {
            PlayerData data = SaveSystem.LoadPlayer();
            Vector3 position;
            position.x = data.position[0];
            position.y = data.position[1];
            position.z = data.position[2];
            transform.position = (position);
        }
        catch
        {

        }

        inputManager = new InputActionManager();
        rb2D = this.GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        inputManager.Enable();
    }

    private void OnDisable()
    {
        inputManager.Disable();
    }

    void Start()
    {
        inputManager.Player.GameMenu.performed += _ => EscapeIsPressed();
    }

    void Update()
    {
        movement = inputManager.Player.Move.ReadValue<Vector2>();
        
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        rb2D.MovePosition((Vector2)transform.position + (movement * speed * Time.deltaTime));
    }

    public void EscapeIsPressed()
    {
        Debug.Log("presed");
        if (!setMenu)
        {
            test.SetActive(true);
            setMenu = true;
        }
                      
        else if (setMenu)
        {
            test.SetActive(false);
            setMenu = false;
        }
    }
}
