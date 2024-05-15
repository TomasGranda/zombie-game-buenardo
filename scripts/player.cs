using Godot;
using System;

public partial class player : CharacterBody2D
{
	// Called when the node enters the scene tree for the first time.
	[Export]
	public float speed = 150f;
	
	public override void _Ready()
	{
	}

	public override void _PhysicsProcess(double delta)
	{
		Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");
		Velocity = direction * speed;

		MoveAndSlide();
	}

}
