using Godot;

public partial class Player : CharacterBody2D
{
	[Export]
	public int Speed { get; set; } = 400;
	private Happy_boo HappyBoo;

	public override void _Ready()
	{
		HappyBoo = GetNode<Happy_boo>("HappyBoo");
	}

	public void GetInput()
	{

		Vector2 inputDirection = Input.GetVector("move_left", "move_right", "move_up", "move_down");
		Velocity = inputDirection * Speed;
	}

	public override void _PhysicsProcess(double delta)
	{
		GetInput();
		MoveAndSlide();

		if (Velocity.Length() > 0.0)
		{
			HappyBoo.Play_walk_animation();
		}
		else
		{
			HappyBoo.Play_idle_animation();
		}
	}
}
