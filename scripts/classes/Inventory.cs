using Godot;

[GlobalClass]
public partial class Inventory : Resource
{
	[Export] public float speed = 150f;
	[Export] public int size = 1;
}