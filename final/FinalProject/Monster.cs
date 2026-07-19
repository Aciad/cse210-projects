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
        else
        {
            int[] direction = [0, 0];
            int distance = 0;
            Random randNum = new Random();
            while (direction[0] == 0)
            {
                direction[0] = randNum.Next(-1, 1);
            }
            while (direction[1] == 0)
            {
                direction[1] = randNum.Next(-1, 1);
            }
            distance = randNum.Next(0, 2);
            Move(distance, direction);
        }
    }
}