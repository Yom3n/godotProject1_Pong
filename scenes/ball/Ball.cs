using Godot;
using System;

public partial class Ball : RigidBody2D
{
    [Export] private float Speed = 50;


    public override void _Process(double delta)
    {
        base._Process(delta);
        // TODO Returns Kinematic collision that can be used to handle bouncing
        // of the walls and sending signal on point gain 
        MoveAndCollide(new Vector2((float)(Speed * delta), 0));
    }
}