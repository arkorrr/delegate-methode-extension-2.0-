using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Backpack
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public double Weight { get; set; }
    public double Volume { get; set; }
    public List<Item> Contents { get; private set; }

    public event EventHandler<ItemEventArgs> ItemAdded;
    public event EventHandler<ItemEventArgs> ItemRemoved;

    public Backpack(string color, string brand, double weight, double volume)
    {
        Color = color;
        Brand = brand;
        Weight = weight;
        Volume = volume;
        Contents = new List<Item>();
    }

    public void AddItem(Item item)
    {
        Contents.Add(item);
        OnItemAdded(new ItemEventArgs(item));
    }

    public void RemoveItem(Item item)
    {
        if (Contents.Remove(item))
        {
            OnItemRemoved(new ItemEventArgs(item));
        }
    }
    protected virtual void OnItemAdded(ItemEventArgs e)
    {
        ItemAdded?.Invoke(this, e);
    }

    protected virtual void OnItemRemoved(ItemEventArgs e)
    {
        ItemRemoved?.Invoke(this, e);
    }
}
public class Item
{
    public string Name { get; set; }
    public double Volume { get; set; }

    public Item(string name, double volume)
    {
        Name = name;
        Volume = volume;
    }
}

public class ItemEventArgs : EventArgs
{
    public Item Item { get; }

    public ItemEventArgs(Item item)
    {
        Item = item;
    }
}