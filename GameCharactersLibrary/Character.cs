namespace GameCharactersLibrary
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }

        public Character(string name, int health, int attackPower)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name}, Health: {Health}, Attack Power: {AttackPower}";
        }

        public virtual void Attack(Character target)
        {
            Console.WriteLine($"{Name} attacks {target.Name} for {AttackPower} damage.");
            target.TakeDamage(AttackPower);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} has been defeated.");
            }
        }
    }
}