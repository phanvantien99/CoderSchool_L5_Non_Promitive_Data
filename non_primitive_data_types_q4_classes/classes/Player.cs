namespace non_primitive_data_types_q4_classes;

class Player
{
    // Question 1: Player Class
    // Create a class named "Player" to represent a character in a role-playing game.
    // Include attributes for the player's name, level, health points (HP), and experience points (XP).
    // Implement methods to level up the player, heal the player, and gain experience points.
    // Hint: Declare a class with properties for name, level, HP, and XP. Implement methods to increase level, heal HP, and gain XP.
    /* Think about how players progress in a typical RPG game. Consider what actions a player can take and how they affect the player's attributes. */
    private string name;
    private int level;
    private int healthPoint;
    private int experiencePoint;
    private float defense;
    private int manaPoint;

    private Inventory inventory;

    private List<Spell> spells;

    public Player(string name, int level, int healthPoint, int experiencePoint, int mana)
    {
        this.Name = name;
        this.Level = level;
        this.HealthPoint = healthPoint;
        this.ExperiencePoint = experiencePoint;
        this.Inventory = new Inventory(this, 10);
        this.manaPoint = mana;
        this.Spells = new List<Spell>();
    }

    public Player()
    {
        this.Name = "Unknow";
        this.Level = 0;
        this.HealthPoint = 100;
        this.manaPoint = 100;
        this.ExperiencePoint = 0;
        this.Defense = 0;
        this.Inventory = new Inventory(this, 10);
        this.Spells = new List<Spell>();
    }


    public string Name { get => name; set => name = value; }
    public int Level { get => level; set => level = value; }
    public int HealthPoint { get => healthPoint; set => healthPoint = value; }
    public int ExperiencePoint { get => experiencePoint; set => experiencePoint = value; }
    public float Defense { get => defense; set => defense = value; }
    internal Inventory Inventory { get => inventory; set => inventory = value; }
    public int ManaPoint { get => manaPoint; set => manaPoint = value; }
    internal List<Spell> Spells { get => spells; set => spells = value; }

    public void IncreaseLevel(int level)
    {
        this.level += level;
    }

    public void IncreaseHP(int hp)
    {
        this.healthPoint += hp;
        if (this.healthPoint > 100)
        {
            this.healthPoint = 100;
        }
    }

    public void GainEXP(int exp)
    {
        this.experiencePoint += exp;
        if (this.experiencePoint > 100)
        {
            int expGain = this.experiencePoint / 100;
            this.level += expGain;
            this.experiencePoint %= 100;
        }
    }

    public void PerformQuest(Quest quest, int progress)
    {
        if (progress < quest.Progress) return;
        // reach check point and award player each checkpoint
        quest.ReachCheckPoint(this, progress);
        quest.AwardPlayer(this, quest.Rewards);
    }

    public void LearnSpell(Spell spell)
    {
        this.spells.Add(spell);
    }

    public void PerformCastSpell(Spell spell, Enemy target)
    {
        spell.CastSpell(this, target);
    }
}