using Godot;
using System;

public partial class player : CharacterBody2D
{
	public override void _PhysicsProcess(double delta)
	{
		var direction = Input.GetVector("move_left", "move_right", "move_up", "move_down");
		var velocity = direction * 600;
		MoveAndSlide();
	}
}
