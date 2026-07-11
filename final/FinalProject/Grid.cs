class Grid
{
    //attributes
    private List<GameObject> _contents;
    private Dictionary<GameObject, int[]> _contentsLocation;
    private int _height;
    private int _width;
    public Grid(int height, int width)
    {
        _height = height;
        _width = width;
        _contents = new List<GameObject>();
        _contentsLocation = new Dictionary<GameObject, int[]>();
    }
    public void AddContent(GameObject gameToken, int[] coordinates )
    {
        _contents.Add(gameToken);
        _contentsLocation.Add(gameToken, coordinates);
    }
    public List<GameObject> GetContent()
    {
        return _contents;
    }
    public int[] GetObjectLocation(GameObject GameObjectName)
    {
        return _contentsLocation[GameObjectName];
    }
    public List<GameObject> GetGameObjectAtCoords(int[] coordinates)
    {
        List<GameObject> gameObjectList = new List<GameObject>();
        foreach (GameObject content in _contents)
        {
            if (_contentsLocation[content].SequenceEqual(coordinates))
            {
                gameObjectList.Add(content);
            }
        }
        return gameObjectList;
    }
    public void ViewportDisplay()
    {
        for (int y = 0; y <= _height; y ++)
        {
            for (int x = 0; x <= _width; x ++)
            {
                List<GameObject> location = GetGameObjectAtCoords([y,x]);
                if (location.Count() == 0)
                {
                    Console.Write("-");
                }
                else
                {
                    try
                    {
                        Console.Write($"{location[^1].GetToken()}");
                    }
                    catch
                    {
                        Console.Write($"|");
                    }
                }
                
            }
            Console.Write($"\n");
        }
    }
}