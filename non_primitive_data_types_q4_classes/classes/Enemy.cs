namespace non_primitive_data_types_q4_classes;
class Enemy
{
    //---------------------------------------------------------------------
    // Question 2: Enemy Class
    // Develop a class called "Enemy" to represent adversaries in a video game.
    // Include properties for the enemy's name, health points (HP), attack power, and defense.
    // Implement methods to calculate damage inflicted by the enemy and to update their HP.
    // Hint: Define a class with attributes for name, HP, attack power, and defense. Create methods to calculate damage and update HP.
    /* Consider the role enemies play in games. They typically attack players and can be defeated by reducing their HP to zero. */

    private string name;
    private int healthPoint;
    private float attackPower;
    private int defense;

    public Enemy()
    {
        this.Name = "Unknow";
        this.HealthPoint = 100;
        this.AttackPower = 0;
        this.Defense = 0;
    }

    public Enemy(string name, int healthPoint, int attackPower, int defense)
    {
        this.Name = name;
        this.HealthPoint = healthPoint;
        this.AttackPower = attackPower;
        this.Defense = defense;
    }

    public string Name { get => name; set => name = value; }
    public int HealthPoint { get => healthPoint; set => healthPoint = value; }
    public float AttackPower { get => attackPower; set => attackPower = value; }
    public int Defense { get => defense; set => defense = value; }


    public void Attack(Player player)
    {
        if (player.HealthPoint > 0)
        {
            float lostHealth = this.attackPower * (100 / (100 + player.Defense));
            player.HealthPoint -= (int)lostHealth;
        }
        else
        {
            // player dead todo....
        }
    }

    public void Defeated()
    {
        this.healthPoint = 0;
        // this enemy is dead todo;
    }

}
