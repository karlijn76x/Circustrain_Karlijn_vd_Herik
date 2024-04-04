using Circustrain_Karlijn_vd_Herik;

public class Animal
{
    public string Name { get; private set; }
    public AnimalSize Size { get; private set; }
    public bool EatsMeat { get; private set; }

    public Animal(AnimalSize size, bool eatsMeat) : this(null, size, eatsMeat)
    {
    }

    public Animal(string name, AnimalSize size, bool eatsMeat)
    {
        Name = string.IsNullOrEmpty(name) ? GenerateName(size, eatsMeat) : name;
        Size = size;
        EatsMeat = eatsMeat;
    }

    private string GenerateName(AnimalSize size, bool eatsMeat)
    {
        return eatsMeat ? $"VleesEter{size}" : $"PlantEter{size}";
    }

    public bool IsFriendlyAnimal(Animal newAnimal)
    {
        
            // Als het nieuwe dier vlees eet
            if (newAnimal.EatsMeat)
            {
                // Als het andere dier ook vlees eet en van dezelfde grootte is, is het niet vriendelijk
                if (this.EatsMeat && newAnimal.Size <= this.Size)
                {
                    return false;
                }
            }
            // Als het nieuwe dier plantaardig eet
            else
            {
                // Als het andere dier vlees eet en van dezelfde grootte is, is het niet vriendelijk
                if (this.EatsMeat && newAnimal.Size == this.Size)
                {
                    return false;
                }

                // Als het andere dier vlees eet en groter is, is het niet vriendelijk
                if (this.EatsMeat && newAnimal.Size < this.Size)
                {
                    return false;
                }
            }
        
        return true;
    }
}
