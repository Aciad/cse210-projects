class Player : Character
{
    //constructor
    public Player() : base() {
        _token = "P";
        _name = "Player";
        _healthPoints = 20;
        _description = "Despite everything it's still you";
    }
    //functionality
    public override void Planner(Turn turnKeeper)
    {
        Menu.turnMenu(this, turnKeeper);
    }
    public void UseHeld()
    {
        _held.UseItem();
    }
    public void SetHeld(int itmeNumber)
    {
        _held = _inventory[itmeNumber];
        _held.SetHolder(this);
    }
    public List<Item> GetInventory()
    {
        return _inventory;
    }
    
}