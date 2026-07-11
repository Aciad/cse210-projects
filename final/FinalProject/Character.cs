abstract class Character : GameObject
{
    //attributes
    protected int _healthPoints;
    protected List<Item> _inventory;
    protected Item _held;
    //constructor
    public Character() : base()
    {
        
    }
    //functionality
    public virtual void Planner()
    {
        
    }
    public virtual void Move()
    {
        
    }
    public virtual void Attack(Character target)
    {
        
    }
    public virtual void PickUp()
    {
        
    }
}