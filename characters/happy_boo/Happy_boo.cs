using Godot;
using System;

public partial class Happy_boo : Node2D
{
	AnimationPlayer animationPlayer;

	public override void _Ready()
	{
		animationPlayer = GetNode<AnimationPlayer>("AnimationPlayer");
	}

	public void Play_idle_animation()
	{
		animationPlayer.Play("idle");
	}

	public void Play_walk_animation()
	{
		animationPlayer.Play("walk");
	}
}
