namespace QuemEEssePokemon;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<TypeInfo> Types { get; set; }
    public Sprites Sprites { get; set; }
    public List<HabitatInfo> Habitats { get; set; }
}

public class TypeInfo
{
    public TypeDetalhe Type { get; set; }
}

public class TypeDetalhe
{
    public string Name { get; set; }
}

public class Sprites
{
    public string Front_default { get; set; }
}

public class HabitatInfo
{
    public HabitatPokemon Habitat { get; set; }

    public class HabitatPokemon
    {
        public string Name { get; set; }
    }
}