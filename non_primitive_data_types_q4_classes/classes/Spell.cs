namespace non_primitive_data_types_q4_classes;



//---------------------------------------------------------------------
// Question 6: Spell Class
// Design a class called "Spell" to represent magical abilities or spells in a fantasy game.
// Include properties for the spell's name, damage, mana cost, and description.
// Implement methods to cast the spell, consume mana, and display spell details.
// Hint: Define a class with attributes for name, damage, mana cost, and description. Implement methods to cast and describe the spell.
/* Consider the mechanics of spellcasting in fantasy games. Spells often have different effects, costs, and descriptions. */
class Spell
{
    private string name;
    private int manaCost;
    private int damage;

    public Spell(string name, int manaCost, int damage)
    {
        this.name = name;
        this.manaCost = manaCost;
        this.damage = damage;
    }

    public string Name { get => name; set => name = value; }
    public int ManaCost { get => manaCost; set => manaCost = value; }
    public int Damage { get => damage; set => damage = value; }

    public void CastSpell(Player caster, Enemy target)
    {
        if (caster.ManaPoint <= 0) return;
        caster.ManaPoint -= this.manaCost;
        target.HealthPoint -= this.damage;
        if (target.HealthPoint < 0)
        {
            target.HealthPoint = 0;
        }
    }
}