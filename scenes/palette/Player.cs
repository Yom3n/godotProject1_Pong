using Godot;
using System;
using System.IO;

public partial class Player : Node2D
{
    private RigidBody2D _body;

    public override void _Ready()
    {
        base._Ready();
        _body = GetNode<RigidBody2D>("Palette");
        if (_body == null)
        {
            throw new FileNotFoundException();
        }
    }

    public override void _PhysicsProcess(double delta)
    {
        base._PhysicsProcess(delta);
        _body.MoveAndCollide(Vector2.Right * 10);
    }
}