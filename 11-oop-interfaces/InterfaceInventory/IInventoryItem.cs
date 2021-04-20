namespace InterfaceInventory
{
    public interface IInventoryItem
    {
        string Name { get; set; }

        public void Use();
    }
}