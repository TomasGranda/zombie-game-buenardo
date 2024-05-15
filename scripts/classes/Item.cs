using Godot;

[GlobalClass]
public partial class Item : Resource
{
    [Export]
    public string id;
    [Export]
    public string name;
    [Export]
    public bool isStackeable = true;
    [Export]
    public Texture2D icon;
}

public enum SlotType
{
    DEFAULT,
}