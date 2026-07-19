abstract class Character : GameObject
{
    //attributes
    protected int _healthPoints;
    protected List<Item> _inventory;
    protected Item _held;
    //constructor
    public Character() : base()
    {
        _inventory = new();
    }
    //functionality
    public void TakeDamage(int damage)
    {
        _healthPoints -= damage;
        if (_healthPoints <= 0)
        {
            _map.RemoveObject(this);
        }
    }
    public virtual void Planner(Turn turnKeeper)
    {
        // Console.Write("Planning");
        // Console.ReadLine();
    }
    public virtual void Move(int rate, int[] direction)
    {
        int[] newCoordinates = _coordinates;
        switch (direction)
        {
            case [0, 1]:
                //up
                newCoordinates[1] -= rate;
                if (_map.GetIsInMapRange(newCoordinates))
                {
                    _coordinates = newCoordinates;
                }
                break;
            case [0, -1]:
                //down
                newCoordinates[1] += rate;
                if (_map.GetIsInMapRange(newCoordinates))
                {
                    _coordinates = newCoordinates;
                }
                break;
            case [-1, 0]:
                //left
                newCoordinates[-0] -= rate;
                if (_map.GetIsInMapRange(newCoordinates))
                {
                    _coordinates = newCoordinates;
                }
                break;
            case [1, 0]:
                //right
                newCoordinates[0] += rate;
                if (_map.GetIsInMapRange(newCoordinates))
                {
                    _coordinates = newCoordinates;
                }
                break;
        }
    }
    public Item GetHeld()
    {
        return _held;
    }
    public int GetHealth()
    {
        return _healthPoints;
    }
    public virtual void Attack(Character target)
    {
        
    }
    public virtual void PickUp()
    {
        List<Item> local = _map.GetItemsAtCoords(_coordinates);
        foreach (Item item in local)
        {
            _map.RemoveObject(item);
        }
        if (local.Count > 0)
        {
            _inventory.AddRange(local);
        }
    }
}