abstract class GameObject
{
    //attributes
    protected string _name;
    protected string _description;
    protected int[] _coordinates;
    protected string _token;

    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int[] GetCoordinates()
    {
        return _coordinates;
    }
    public string GetToken()
    {
        return _token;
    }
    public int[] GetGameObjectDistance(GameObject target)
    {
        int[] distance = [0, 0];
        int[] targetCoordinates = target.GetCoordinates();
        distance[0] = targetCoordinates[0] - _coordinates[0];
        distance[1] = targetCoordinates[1] - _coordinates[1];
        return distance;
    }
}