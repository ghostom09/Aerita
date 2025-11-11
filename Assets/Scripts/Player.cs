using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Player_Input input;
    public Player_Move move;
    
    public Player_State state;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[Serializable]
public class Player_State
{
    public float hp;
    public float breath;
    public float speed;
    public float damage;
    public float jumpForce;
}
