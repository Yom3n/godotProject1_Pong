using Godot;
using System;

public partial class Ball : RigidBody2D
{
    [Export] public float Speed = 10;

    [Export] public Vector2 MoveDirection;

    public override void _Ready()
    {
        MoveDirection = new Vector2(Speed, Speed);
    }

    public override void _Process(double delta)
    {
        
        KinematicCollision2D collision = MoveAndCollide(MoveDirection * Speed * (float)delta);
        if (collision != null)
        {
            _handleCollision(collision);
        }
    }


    private void _handleCollision(KinematicCollision2D collision)
    {
        GD.Print(collision.GetNormal());
        MoveDirection = MoveDirection.Bounce(collision.GetNormal());
    }
}