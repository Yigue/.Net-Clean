namespace CleanArchitecture.Domain.Abstractions;

public abstract class Entity<TEntityID>
{
    protected Entity()
    {

    }
    private readonly List<IDomainEvent> _domainEvents = new();
    
    protected Entity(TEntityID id)
    {
        Id = id;
    }
    
    public TEntityID Id {get ; init;}

    public IReadOnlyList<IDomainEvent> GetDomainEvents()
    {
        return _domainEvents.ToList();
    }

    public void ClearDomainEvents()
    {
        _domainEvents.Clear();
    }

    protected void RaiseDomainEvent(IDomainEvent domainEvent)
    {
        _domainEvents.Add(domainEvent);
    }


}