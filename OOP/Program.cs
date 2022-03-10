

var backpack1 = new Backpack("blue", "small", false);
var backpack2 = new Backpack("red", "medium", false);
var backpack3 = new Backpack("green", "large", false);

backpack1.openBag();
backpack1.putIn("lunch");
backpack1.putIn("jacket");
backpack1.closeBag();
backpack1.openBag();
backpack1.takeOut("jacket");
backpack1.closeBag();

class Backpack
{
    private string colour;
    private string size;
    private List<string> items = new List<string>();
    private bool open;
    public Backpack(string Colour, string Size, bool Open)
    {
        colour = Colour;
        size = Size;
        open = Open;
    }

    public void openBag()
    {
        open = true;
        Console.WriteLine($"you opened the {size} {colour} backpack");
    }

    public void closeBag()
    {
        open = false;
        Console.WriteLine($"you closed the {size} {colour} backpack");
    }

    public void putIn(string item)
    {
        items.Add(item);
        Console.WriteLine($"you put in your {item} into the {size} {colour} backpack");
    }

    public void takeOut(string item)
    {
        items.Remove(item);
        Console.WriteLine($"you took out your {item} from the {size} {colour} backpack");
    }
}