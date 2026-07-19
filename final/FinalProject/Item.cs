abstract class Item : GameObject
{
    //attribures
    protected int _weight;
    protected int _value;
    protected Character _holder;
    public virtual void UseItem()
    {
        
    }
    public void SetHolder(Character holder)
    {
        _holder = holder;
    }
}