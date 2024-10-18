namespace CleanArchitecture.Domain.Vehiculos;
public record VehiculoId(Guid v)
{
    public static VehiculoId New()=> new(Guid.NewGuid());
}
