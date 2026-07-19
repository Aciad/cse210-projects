abstract class Consumable : Item
{
    protected int _restoreValue;

    public override void UseItem()
    {
        _holder.IncreaseHealth(_restoreValue);
        _holder.RemoveFromInventory(this);
    }
}