abstract class Weapon : Item
{
    //attributes
    protected int _damage;
    protected int _range;
    //functionality
    public int GetDamage()
    {
        return _damage;
    }
    public override void UseItem()
    {


        // Console.WriteLine($"{_map.GetWithinRange(_range, this)}");
        //BEING ALLOWED TO ATTACK YOURSELF IS A FEATURE NOT A BUG!!!
        List<GameObject> withinRange = _map.GetWithinRange(_range, _holder);
        try
        {
            if (withinRange.OfType<Character>().Count() != 0)
            {
                foreach (Character character in _map.GetWithinRange(_range, this).OfType<Character>())
                {
                    bool attacked = false;
                    Console.WriteLine($"Would you like to attack the {character.GetName()}?");
                    Console.WriteLine("Type y/n");
                    string selection = Console.ReadLine();
                    switch (selection)
                    {
                        case "y":
                            character.TakeDamage(_damage);
                            attacked = true;
                            break;
                        default:
                            break;
                    }
                    if (attacked)
                    {
                        break;
                    }
                }
            }
        }
        catch
        {
            
        }
    }
}