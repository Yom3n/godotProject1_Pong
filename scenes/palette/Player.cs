using Godot;
using System;
using System.IO;

public partial class Player : Node2D
{
    [Export] public float Speed = 50f;

    private CharacterBody2D _body;


    public override void _Ready()
    {
        base._Ready();
        _body = GetNode<CharacterBody2D>("Palette");
    }

    public override void _Process(double delta)
    {
        _handleMovement(delta);
    }

    private void _handleMovement(double delta)
    {
        Vector2 direction = _getMoveDirection();

        if (direction == Vector2.Zero)
        {
            return;
        }

        _body.MoveAndCollide(direction * Speed * (float)delta);
    }

    private Vector2 _getMoveDirection()
    {
        Vector2 direction = new Vector2();
        if (Input.IsActionPressed("move_up"))
        {
            direction = Vector2.Up;
        }
        else if (Input.IsActionPressed("move_down"))
        {
            direction = Vector2.Down;
        }

        return direction;
    }
}