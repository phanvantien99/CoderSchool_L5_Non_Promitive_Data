namespace non_primitive_data_types_q4_classes;

class Potion : Items
{
    private int healthPoint;
    private static int idGlobal = -1;

    // this annotate for compiler the initialize data in constructor
    [System.Diagnostics.CodeAnalysis.SetsRequiredMembers] 
    public Potion(string name, int healthPoint)
    {
        this.Id = Interlocked.Increment(ref idGlobal);
        this.Name = name;
        this.healthPoint = healthPoint;
        this.Quantity = 1;
    }
    public int HealthPoint { get => healthPoint; set => healthPoint = value; }

    public void Use(Player player)
    {
        player.HealthPoint += this.healthPoint;
        if (player.HealthPoint > 100)
        {
            player.HealthPoint = 100;
        }
    }
}