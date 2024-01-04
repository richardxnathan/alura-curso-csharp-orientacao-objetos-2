public class Consulta
{
    public Pet Animal { get; set; }
    public Dono Tutor { get; set; }
    public Veterinario Profissional { get; set; }
    public string Data { get; set; }

    public Consulta(Pet pet, Dono dono, Veterinario veterinario, string data)
    {
        Animal = pet;
        Tutor = dono;
        Profissional = veterinario;
        Data = data;
    }
}