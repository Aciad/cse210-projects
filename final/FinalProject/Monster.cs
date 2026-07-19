abstract class Monster : Character
{
    protected int _range;
    protected int _damage;
    public Monster() : base()
    {
        
    }
    //functionality
    public override void Planner(Turn turnKeeper)
    {
        if (_map.GetWithinRange(5, this).OfType<Player>().Count() != 0)
        {
            foreach (Character character in _map.GetWithinRange(_range, this).OfType<Player>())
            {
                character.TakeDamage(_damage);
            }
        }
    }
}