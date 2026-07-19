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
    public void AddContent(GameObject gameToken, int[] coordinates, Map map)
    {
        _contents.Add(gameToken);
        gameToken.SetCoordinates(coordinates);
        _contentsLocation.Add(gameToken, coordinates);
        gameToken.SetMap(map);


    }
    public List<GameObject> GetContent()
    {
        return _contents;
    }
    public int[] GetObjectLocation(GameObject GameObjectName)
    {
        return _contentsLocation[GameObjectName];
    }
    public int[] GetSize()
    {
        return [_width,_height];
    }
    public bool GetIsInMapRange(int[] coordinates)
    {
        if (coordinates[1] <= _height && coordinates[1] >= 0 && coordinates[0] <= _width && coordinates[0] >= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool GetIsInRange(GameObject self, GameObject target, int range)
    {
        
        if (target.GetCoordinates()[1] <= self.GetCoordinates()[1] + range && self.GetCoordinates()[0] - range >= 0 &&target.GetCoordinates()[0] <= self.GetCoordinates()[0] + range && self.GetCoordinates()[0] - range >= 0 )
        {
            return true;
        }
        else
        {
            return false;
        }
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
    public List<Item> GetItemsAtCoords(int[] coordinates)
    {
        List<Item> itemList = new List<Item>();
        foreach (Item item in _contents.OfType<Item>())
        {
            if (_contentsLocation[item].SequenceEqual(coordinates))
            {
                itemList.Add(item);
            }
        }
        return itemList;
    }
    public List<GameObject> GetWithinRange(int range, GameObject asker)
    {
        List<GameObject> withinRange = new();
        for (int y = asker.GetCoordinates()[1] - range; y <= asker.GetCoordinates()[1] + range; y ++)
        {
            for (int x = asker.GetCoordinates()[0] - range; x <= asker.GetCoordinates()[0] + range; x ++)
            {
                List<GameObject> location = GetGameObjectAtCoords([x,y]);
                if (location.Count() != 0)
                {
                    withinRange.AddRange(location);
                }
            }
        }
        return withinRange;
    }
    public void RemoveObject(GameObject gameObject)
    {
        _contents.Remove(gameObject);
        _contentsLocation.Remove(gameObject);
    }
    public void ViewportDisplay()
    {
        for (int y = 0; y <= _height; y ++)
        {
            for (int x = 0; x <= _width; x ++)
            {
                List<GameObject> location = GetGameObjectAtCoords([x,y]);
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