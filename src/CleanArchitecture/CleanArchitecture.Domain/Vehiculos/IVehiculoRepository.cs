using CleanArchitecture.Domain.Vehiculos.Vehiculo.VehiculoId;
namespace CleanArchitecture.Domain.Vehiculos;

public interface IVehiculoRepository
{
    Task<Vehiculo?> GetByIdAsync(VehiculoId id, CancellationToken cancellationToken = default);
}