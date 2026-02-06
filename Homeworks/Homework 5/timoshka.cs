abstract class Character : IDamageable
{
    private string name;
    private int health;

    public string Name
    {
        get { return name; }
    }
    
    public string Health
    {
        get { return health; }
    }

    protected Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }
    
    public abstract void Attack();

    public void Move()
    {
        Console.WriteLine($"{name} движется.");
    }
}

//Класс должен быть абстрактным, потому что сам по себе персонаж не имеет конкретной атаки. Это базовый класс для всех игровых персонажей, конкретные типы атак определяются в наследниках



class Warrior : Character
{
    public Warrior(string name, int health) : base(name, health) { }
    
    public override void Attack()
    {
        Console.WriteLine($"{Name} бьет мечом");
    }
}

class Mage : Character
{
    public Mage(string name, int health) : base(name, health) { }
    
    public override void Attack()
    {
        Console.WriteLine($"{Name} колдует");
    }
}


Character[] characters = new Character[]
{
    new Warrior("Артур", 100),
    new Mage("Мерлин", 80)
};

foreach (Character character in characters)
{
    character.Attack();
}

//При вызова метода Attack() через переменную типа Character происходит динамическое связывание и вызывается реализация метода из конкретного класса-наследника

interface IDamageable
{
    void TakeDamage(int damage);
}

abstract class Character : IDamageable
{
    public string name;
    public int health;
    
    public string Name
    {
        get { return name; }
    }
    
    public string Health
    {
        get { return health; }
    }

    protected Character(string name, int health)
    {
        this.name = name;
        this.health = health;
    }
    
    public abstract void Attack();

    public void Move()
    {
        Console.WriteLine($"{name} движется");
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Console.WriteLine($"{name} получил {damage} урона. Твое здоровье теперь: {health}");
    }
}


class Assassin : Character
{
    public override void Attack()
    {
        Console.WriteLine($"{name} скрыто нападает");
    }
}
