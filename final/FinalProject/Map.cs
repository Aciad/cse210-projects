class Map : Grid
{
    private string _name;
    public Map(int width, int height, string name) : base(width: width, height: height)
    {
        _name = name;
    }
}