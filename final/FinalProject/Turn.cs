class Turn
{
    private Map _map;
    private List<Character> _turnOrder;
    private int _turnCount;
    public Turn(List<Character> turnOrder)
    {
        _turnOrder = turnOrder;
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
    public void GameLoop()
    {
        bool inLoop = true;
        while (inLoop)
        {
            TakeTurn();
            foreach (Character character in _turnOrder)
            {
                if (character.GetType() != typeof(Player))
                {
                    character.Planner();
                }
                else
                {

                }
            }
        }
    }
    public void TakeTurn()
    {
        Console.Clear();
        _map.ViewportDisplay();
        Console.Write($"\n");
        Console.ReadLine();
        //debug nonsence
        // foreach (GameObject content in _map.GetContent())
        // {
        //     Console.WriteLine($"{content.GetName()}");
        //     Console.WriteLine($"{content.GetToken()}");
        //     Console.WriteLine($"{_map.GetObjectLocation(content)[0]}{_map.GetObjectLocation(content)[1]}");
        // }
    }

}