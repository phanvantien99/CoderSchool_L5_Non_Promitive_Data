namespace non_primitive_data_types_q4_classes;

class Inventory
{
    private int capacity;
    private List<Items> items;
    private Player owner;

    public Inventory(Player owner, int capacity)
    {
        this.Items = new List<Items>();
        this.Owner = owner;
        this.capacity = capacity;
    }

    internal List<Items> Items { get => items; set => items = value; }
    internal Player Owner { get => owner; set => owner = value; }

    public void addItems(List<Items> items)
    {
        if (items.Count > 0 && items.Count < capacity)
        {
            this.items.AddRange(items);
        }
    }

    public void removeItems(int id, int quantity)
    {
        Items item = items.Find(obj => obj.Id == id);
        if (item == null) return;
        if (quantity > 0)
        {
            item.Quantity -= quantity;
            if (item.Quantity <= 0)
            {
                items.Remove(item);
            }
        }
    }

    public List<Items> searchItemsByName(string? name = null)
    {
        if (name == null) return items;

        return items.FindAll(obj => obj.Name.Contains(name));
    }
}