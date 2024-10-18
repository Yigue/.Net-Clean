namespace CleanArchitecture.Domain.Alquileres;

public record AlquilerId(Guid v)
{
    public static AlquilerId New()=> new(Guid.NewGuid());
}
