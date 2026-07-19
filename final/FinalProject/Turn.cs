class Turn
{
    private Map _map;
    private List<Character> _turnOrder;
    private int _turnCount;
    private bool _loop;
    public Turn(Map map, bool loop = true)
    {
        // _turnOrder = turnOrder;
        _turnOrder = new List<Character>();
        _loop = true;
        _map = map;
    }
    public Turn(Map map)
    {
        _map = map;
        List<Character> characters = new();
        foreach (Character character in map.GetContent().OfType<Character>())
        {
            _turnOrder.Add(character);
        }
        _turnOrder = characters;
    }
    public Map getMap()
    {
        return _map;
    }
    public void SetLoop(bool loop = true)
    {
        _loop = loop;
    }
    public void AddCharacter(Character character)
    {
        _turnOrder.Add(character);
    }
    public void GameLoop(Player player)
    {
        while (_loop)
        {
            _turnCount ++;
            TakeTurn();
            
            foreach (Character character in _turnOrder)
            {
                character.Planner(this);
            }
            if (player.GetHealth() <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("YOU DIED!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                _loop = false;
            }
            // Console.WriteLine("Type1 to exit");
            // try
            // {
            //     int select = int.Parse(Console.ReadLine());
            //     if (select == 1)
            //     {
            //         inLoop = false;
            //     }   
            // }
            // catch
            // {
                
            // }
        }
    }
    public void TakeTurn()
    {
        Console.Clear();
        _map.ViewportDisplay();
        Console.Write($"\n");
        Console.WriteLine($"Turn Number: {_turnCount}");
        // foreach (Character character in _turnOrder)
        // {
        //     Console.WriteLine($"Character : {character.GetName()}");
        // }
        // Console.ReadLine();
    }

}